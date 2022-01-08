using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Outrage.Patternfly.Validators
{
    public class DelegateValidator : ComponentBase
    {
        private ValidationMessageStore messageStore;
        private bool valid;

        [CascadingParameter]
        private EditContext CurrentEditContext { get; set; }

        [Parameter]
        public EventHandler<ValidationArgs> Validate { get; set; }
        public bool Valid => valid;

        protected override void OnInitialized()
        {
            valid = true;
            if (CurrentEditContext == null)
            {
                throw new InvalidOperationException(
                    $"{nameof(DelegateValidator)} requires a cascading " +
                    $"parameter of type {nameof(EditContext)}. " +
                    $"For example, you can use {nameof(DelegateValidator)} " +
                    $"inside an {nameof(EditForm)}.");
            }

            messageStore = new ValidationMessageStore(CurrentEditContext);

            CurrentEditContext.OnValidationRequested += (s, e) =>
            {
                messageStore.Clear();
                var validationArgs = new ValidationArgs();
                Validate(this, validationArgs);
                this.DisplayErrors(validationArgs.Errors);
            };

            CurrentEditContext.OnFieldChanged += (s, e) =>
                messageStore.Clear(e.FieldIdentifier);
        }

        private void DisplayErrors(IDictionary<string, List<string>> errors)
        {
            foreach (var err in errors)
            {
                messageStore.Add(CurrentEditContext.Field(err.Key), err.Value);
                valid = false;
            }

            CurrentEditContext.NotifyValidationStateChanged();
        }

        private void ClearErrors()
        {
            messageStore.Clear();
            valid = true;
            CurrentEditContext.NotifyValidationStateChanged();
        }
    }

    public class ValidationArgs
    {
        private readonly IDictionary<string, List<string>> errors = new Dictionary<string, List<string>>();

        public IDictionary<string, List<string>> Errors => errors;

        public void AddError(string name, string error)
        {
            if (!errors.ContainsKey(name))
                errors[name] = new List<string>();
            errors[name].Add(error);
        }

        public bool IsValid()
        {
            return !errors.Any();
        }
    }
}
