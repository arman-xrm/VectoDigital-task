namespace VECTO.DIGITAL_Task.Models.RequestModels
{
    public class ProcessImageRequestModel
    {
        public byte[] Image { get; set; }
        public string EffectName { get; set; }
        public int Radius { get; set; }
        public int Size { get; set; }

    }
}
