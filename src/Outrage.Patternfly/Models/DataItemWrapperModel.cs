namespace Outrage.Patternfly.Models
{
    public class DataItemWrapperModel<TItemModel>
    {
        public DataItemWrapperModel(TItemModel item)
        {
            this.Item = item;
            this.IsSelected = false;
        }

        public TItemModel Item { get; private set; }
        public bool IsSelected { get; set; }
    }
}
