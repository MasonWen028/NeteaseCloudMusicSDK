using System;
using System.Threading.Tasks;
using NeteaseCloudMusicSDK.Models.Response;

namespace NeteaseCloudMusicApi_SDK.Interfaces
{
    public interface IDjRadioService
    {
        Task<ApiResponse> DjradioTop();
    }
}