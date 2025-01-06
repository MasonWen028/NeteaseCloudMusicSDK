using System;
using System.Threading.Tasks;
using NeteaseCloudMusicSDK.Models.Response;

namespace NeteaseCloudMusicApi_SDK.Interfaces
{
    public interface ICreatorService
    {
        Task<ApiResponse> CreatorAuthinfoGet();
    }
}