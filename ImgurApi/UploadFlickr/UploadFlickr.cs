using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FlickrNet;
using FlickrNet.Exceptions;

namespace UploadFlickr
{
    public class UploadFlickr
    {
        public string link { get; private set; }
        public string error { get; private set; }
        public bool Upload(string filename)
        {
            bool output = false;
            if (!CheckFileExist(filename))
            {
                error = "File Not Found";
                return false;
            }

            try
            {
                var f = FlickrManager.GetAuthInstance();
                string photoId = f.UploadPicture(filename, null, null, null, false,
                    false, false);
                PhotoInfo info = f.PhotosGetInfo(photoId);
                link = info.OriginalUrl;
                return true;
            }
            catch (BadUrlFoundException badUrlFoundException)
            {
                error = badUrlFoundException.Message;
            }
            catch (FormatNotFoundException formatNotFoundException)
            {
                error = formatNotFoundException.Message;
            }
            catch (InvalidApiKeyException invalidApiKeyException)
            {
                error = invalidApiKeyException.Message;
            }
            catch (InvalidSignatureException invalidSignatureException)
            {
                error = invalidSignatureException.Message;
            }
            catch (LoginFailedInvalidTokenException loginFailedInvalidTokenException)
            {
                error = loginFailedInvalidTokenException.Message;
            }
            catch (MethodNotFoundException methodNotFoundException)
            {
                error = methodNotFoundException.Message;
            }
            catch (MissingSignatureException missingSignatureException)
            {
                error = missingSignatureException.Message;
            }
            catch (PermissionDeniedException permissionDeniedException)
            {
                error = permissionDeniedException.Message;
            }
            catch (PhotoNotFoundException photoNotFoundException)
            {
                error = photoNotFoundException.Message;
            }
            catch (PhotosetNotFoundException photosetNotFoundException)
            {
                error = photosetNotFoundException.Message;
            }
            catch (ServiceUnavailableException serviceUnavailableException)
            {
                error = serviceUnavailableException.Message;
            }
            catch (UserNotFoundException userNotFoundException)
            {
                error = userNotFoundException.Message;
            }
            catch (UserNotLoggedInInsufficientPermissionsException userNotLoggedInInsufficientPermissionsException)
            {
                error = userNotLoggedInInsufficientPermissionsException.Message;
            }
            return output;
        }

        private bool CheckFileExist(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
