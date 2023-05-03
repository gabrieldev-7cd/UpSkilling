
namespace WindowsFormsUPSKILLINGGAMA.Models.DTO
{
    public class ComboBoxVeiculos
    {
        public int Id { get; set; }
        public string Display { get; set; }

        public ComboBoxVeiculos(int id, string display)
        {
            Id = id;
            Display = display;
        }
    }
}
