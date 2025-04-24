namespace Feedback_Form.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email_Id { get; set; }
        //public string Email_ID { get; internal set; }
        public required string Mobile_No { get; set; }
        public int Customer_ID { get; internal set; }
    }
}
