using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IDigitalFileRepository
    {
         Task<IPhoto> GetPhotoById(int photoId);
    }
}