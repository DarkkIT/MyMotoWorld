namespace MyMotoWorld.Data.Models
{
    using MyMotoWorld.Data.Common.Models;

    public class Message : BaseModel<int>
    {
        public string User { get; set; }

        public string Text { get; set; }
    }
}
