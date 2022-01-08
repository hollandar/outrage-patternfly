namespace Outrage {

    export class BlazorStripe {
        static stripeInstance: stripe.Stripe;
        static elements: stripe.elements.Elements;
        static cardElement: any;

        static Initialize(publishableKey: string) {
            if (!Stripe)
                throw new Error("Stripe is not loaded.");

            if (!BlazorStripe.stripeInstance) {
                BlazorStripe.stripeInstance = Stripe(publishableKey);
                BlazorStripe.elements = BlazorStripe.stripeInstance.elements();
            }
        }

        static CreateCardElement(cardDiv:HTMLDivElement, dotNetInstance:any, onChangeCallback) {
            if (BlazorStripe.cardElement == null) {
                BlazorStripe.cardElement = BlazorStripe.elements.create("card");
                BlazorStripe.cardElement.mount(cardDiv);

                if (dotNetInstance && onChangeCallback) {
                    BlazorStripe.cardElement.on("change", function (event) {
                        dotNetInstance.invokeMethodAsync(onChangeCallback, event);
                    });
                }
            }
        }
        static PayWithCard (clientSecret, dotNetInstance, callback) {
            BlazorStripe.stripeInstance
                .confirmCardPayment(clientSecret, {
                    payment_method: {
                        card: BlazorStripe.cardElement
                    }
                })
                .then(function (result) {
                    BlazorStripe.DestroyCardElement();
                    dotNetInstance.invokeMethodAsync(callback, result);
                });
        }
        static DestroyCardElement() {
            BlazorStripe.cardElement.destroy();
            BlazorStripe.cardElement = null;
        }
        static CreatePaymentMethod(billingName:string, dotNetInstance: any, onSuccessCallback, onErrorCallback) {
            BlazorStripe.stripeInstance
                .createPaymentMethod({
                    type: 'card',
                    card: BlazorStripe.cardElement,
                    billing_details: {
                        name: billingName
					}
                })
                .then((result) => {
                    if (result.error) {
                        if (dotNetInstance && onErrorCallback)
                            dotNetInstance.invokeMethodAsync(onErrorCallback, result);
                    } else {
                        if (dotNetInstance && onSuccessCallback)
                            dotNetInstance.invokeMethodAsync(onSuccessCallback, result);
                    }
                })
                .catch((error) => {
                    if (dotNetInstance && onErrorCallback)
                        dotNetInstance.invokeMethodAsync(onErrorCallback, error);
                });
        }
        static RedirectToCheckout(sessionId: string, dotNetInstance: any, onSuccessCallback, onErrorCallback) {
            BlazorStripe.stripeInstance
                .redirectToCheckout({ sessionId: sessionId })
                .then((result) => {
                    if (result.error) {
                        if (dotNetInstance && onErrorCallback)
                            dotNetInstance.invokeMethodAsync(onErrorCallback, result.error.message);
                    } else {
                        if (dotNetInstance && onSuccessCallback)
                            dotNetInstance.invokeMethodAsync(onSuccessCallback);
                    }
                })
                .catch((error) => {
                    if (dotNetInstance && onErrorCallback)
                        dotNetInstance.invokeMethodAsync(onErrorCallback, error.message);
                });
		}
    }
}
