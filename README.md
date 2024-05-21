##### This is a project in progress. There WILL be bugs, glitches and other unexpected behavior. Considering reporting these if you can.

<hr>

## yt-dl-protocol (Download almost every video on a site from a bookmark link) for Web Browsers

This repository provides a versatile Bookmarklet that allows you to quickly download media content from the current webpage URL using a custom `ytdl://` protocol (. The bookmarklet communicates with small, locally ran C# utility which relies on `youtube-dlp` to handle downloads. This utility does not run in the background, ensuring that system resources are used only when necessary.

This little project is still in its early stages and any contributions (no money!) are appreaciated. I hope someone finds as useful as I do.

## Requirements
- Tested on Windows 10 with .NET Framework 4.8.1.
- An FFmpeg.exe file.
- Administrator privileges (changes will be made to the computer registry)

## Features
- **List of Support**: Given that this tool relies on [youtube-dlp](youtube-dlp), there are hundreds of sites which (in theory) this tool should also.
- **Instant Downloads**: Easily download media content supported by `youtube-dlp` by clicking the Bookmarklet. **Beware!** quickly will not make your download go faster.
- **Simple Setup**: Add the Bookmarklet to your browser's bookmarks bar with a single line of JavaScript.
- **User-Friendly**: No need for command prompt knowledge; clicking the Bookmarklet starts the download process immediately.
- **No Background Processes**: The application runs only when needed, ensuring efficient use of system resources.

## Installation

### C# Backend

1. Download the latest version from the [Releases](Releases) page.
2. Save the file to a permanent location. I cannot be moved or named (unless you wish to unregister the protocol).
3. This software requires access to the system registry. Therefore it has to be run as an Administrator.
4. 
### Bookmarklet

1. Create a new bookmark in your web browser.
2. Name the bookmark something memorable, like `ytdl Bookmarklet`.
3. Copy the following JavaScript code:

    ```javascript
    javascript:(function(){var currentURL=window.location.href;var ytdlURL='ytdl://'+currentURL;window.open(ytdlURL,'_self');})();
    ```

4. Paste the copied JavaScript code into the URL or "Location" field of the bookmark.
5. Save the bookmark.

## Screenshots and Usage

https://github.com/dvingerh/yt-dl-protocol/assets/8366383/7102c351-7ad0-4144-be48-7679c61c9f55

![image](https://github.com/dvingerh/yt-dl-protocol/assets/8366383/7e22861a-c166-4c95-b915-40a1ba1cbe5e)

![image](https://github.com/dvingerh/yt-dl-protocol/assets/8366383/bde6c130-2285-4815-8bbb-7367740ce840)

![image](https://github.com/dvingerh/yt-dl-protocol/assets/8366383/3a0148ad-2ec7-4ae7-8280-376cbd0e053e)



### Bookmarklet

1. Navigate to any webpage you want to download media from.
2. Click the `ytdl Bookmarklet` bookmark in your bookmarks bar.
3. The current URL will be opened with the `ytdl://` protocol, and the C# backend application will start downloading the media content (if supposed).
**Tip** You can open a new tab, type `ytdl://` yourself and an URL of choice. This will also trigger a download.

### C# Backend
1. When the Bookmarklet was received by the backend is received, it'll get right started with your request. An interface will be shown displaying the approximate progress of the downloaded media file.

## Compatibility

- The Bookmarklet should work in most modern web browsers, including Chrome, Firefox, Safari, and Edge.
- Ensure that you have an application or handler set up to process the `ytdl://` protocol for the best experience. This can be done by running the provided executable file.

## Contributing

Contributions are welcome! If you have suggestions or improvements, feel free to create an issue or submit a pull request.

## License

I will be adopting the UnLicense.



