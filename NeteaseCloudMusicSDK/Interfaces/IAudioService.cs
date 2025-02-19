using System.Threading.Tasks;
using NeteaseCloudMusicSDK.Models.Response;

namespace NeteaseCloudMusicApi_SDK.Interfaces
{
    /// <summary>
    /// Defines methods to handle audio-related functionalities in the Netease Cloud Music API.
    /// </summary>
    public interface IAudioService
    {
        /// <summary>
        /// Matches audio files to corresponding metadata or tracks in the system.
        /// </summary>
        /// <param name="requestModel">The request model containing parameters for audio matching.</param>
        /// <returns>An <see cref="ApiResponse"/> containing the match results for the audio files.</returns>
        Task<ApiResponse> MatchAudio(AudioMatchRequestModel requestModel);
    }
}
