namespace MementoGof
{
    public class Part
    {
        public string PartName { get; set; }
        public int PartProgress { get; set; }

        public PartOld Save()
        {
            return new PartOld()
            {
                PartName = PartName,
                PartProgress = PartProgress
            };
        }

        public void LoadPart(PartOld partOld)
        {
            PartName = partOld.PartName;
            PartProgress = partOld.PartProgress;
        }
    }
}