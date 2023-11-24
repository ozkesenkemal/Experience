namespace StateGof
{
    public class Asistant
    {
        public IMod _asistantMod;

        public Asistant()
        {
            _asistantMod = new Open();
        }

        public void ChangeMod(IMod mod)
        {
            _asistantMod = mod;
        }

        public void Answer()
        {
            _asistantMod.Answer();
        }
    }
}