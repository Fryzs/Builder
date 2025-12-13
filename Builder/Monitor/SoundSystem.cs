using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SoundSystem
    {
        public bool HasSpeakers { get; }
        public int PowerWatts { get; }
        public bool HasHeadphoneJack { get; }

        public SoundSystem(bool hasSpeakers, int powerWatts, bool hasHeadphoneJack)
        {
            HasSpeakers = hasSpeakers;
            PowerWatts = powerWatts;
            HasHeadphoneJack = hasHeadphoneJack;
        }

        public string GetDescription()
        {
            if (!HasSpeakers && !HasHeadphoneJack)
                return "немає вбудованого звуку";

            var list = new List<string>();
            if (HasSpeakers)
                list.Add($"динаміки ~{PowerWatts} Вт");
            if (HasHeadphoneJack)
                list.Add("роз'єм для навушників");

            return string.Join(", ", list);
        }
        public SoundSystem Clone()
        {
            return new SoundSystem(HasSpeakers, PowerWatts, HasHeadphoneJack);
        }
    }
}
