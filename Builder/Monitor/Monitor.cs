using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Monitor
    {
        public string Model { get; set; }
        public double DiagonalInches { get; set; }
        public ScreenPanel Panel { get; set; }
        public StandSpec Stand { get; set; }
        public PortSet Ports { get; set; }
        public SoundSystem Sound { get; set; }
        public Backlight Backlight { get; set; }

        public string ShowInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Модель: {Model}");
            sb.AppendLine($"Діагональ: {DiagonalInches}\"");
            sb.AppendLine($"Панель: {Panel?.GetDescription()}");
            sb.AppendLine($"Підставка: {Stand?.GetDescription()}");
            sb.AppendLine($"Порти: {Ports?.GetDescription()}");
            sb.AppendLine($"Аудіо: {Sound?.GetDescription()}");
            sb.AppendLine($"Підсвічування: {Backlight?.GetDescription()}");

            return sb.ToString();
        }
    }

}
