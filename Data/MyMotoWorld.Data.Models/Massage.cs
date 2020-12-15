namespace MyMotoWorld.Data.Models
{
    using MyMotoWorld.Data.Common.Models;

    public class Massage : BaseModel<int>
    {
        public string User { get; set; }

        public string Text { get; set; }
    }
}
