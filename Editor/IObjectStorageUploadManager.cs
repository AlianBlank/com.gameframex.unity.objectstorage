namespace GameFrameX.ObjectStorage.Editor
{
    public interface IObjectStorageUploadManager : IObjectStorageManager
    {
        /// <summary>
        /// 上传的目标路径
        /// </summary>
        /// <param name="savePath"></param>
        void SetSavePath(string savePath);

        /// <summary>
        /// 上传目录
        /// </summary>
        /// <param name="localDirectory"></param>
        void UploadDirectory(string localDirectory);

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="localFilePathAndName"></param>
        bool UploadFile(string localFilePathAndName);
    }
}