using webAPI.Models.DTO;
namespace webAPI.Data
{
    public class ModelsStore
    {
        public static List<ModelsDTO> modelDTOs = new List<ModelsDTO> {
            new ModelsDTO{Id = 1, Name = "00000" },
            new ModelsDTO{Id = 2, Name = "22222" }
        };
    }
}
