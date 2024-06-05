##### This is a project in progress. There WILL be bugs, glitches and other unexpected behavior. Considering reporting these if you can.

<hr>

## yt-dl-protocol

This repository provides a versatile bookmarklet that allows you to quickly download media content from the current webpage URL using a custom `ytdl://` protocol (. The bookmarklet communicates with small, locally ran C# utility which relies on `youtube-dl` to handle downloads. This utility does not run in the background, ensuring that system resources are used only when necessary.

This little project is still in its early stages and any contributions (no money!) are appreaciated. I hope someone finds it as useful as I do.

## Requirements
- Tested on Windows 10 with .NET Framework 4.8.1.
- An youtube-dl.exe file (available from [here](https://github.com/yt-dlp/yt-dlp)).
- Administrator privileges (changes will be made to the computer registry which is required to register the protocol).

## Features
- **List of Support**: Given that this tool relies on [youtube-dlp](youtube-dlp), there are hundreds of sites which (in theory) this tool should also support.
- **Instant Downloads**: Easily download media content supported by `youtube-dlp` by clicking the bookmarklet.
- **Simple Setup**: Register the `ytdl://` protocol within the utility and add the bookmarklet to your browser's bookmarks bar. That's all.
- **No Background Processes**: The application runs only when needed, ensuring efficient use of system resources.

## Installation

1. Create a new bookmark in your web browser.
2. Name the bookmark something memorable, like `Download with yt-dl`.
3. Copy the following JavaScript code:

    ```javascript
    javascript:(function(){var currentURL=window.location.href;var ytdlURL='ytdl://'+currentURL;window.open(ytdlURL,'_self');})();
    ```

4. Paste the copied JavaScript code into the URL or "Location" field of the bookmark.
5. Save the bookmark.
6. Lastly, ensure you have registered the protocol within the utility's interface. You can access the interface by simply opening the executable the way you would any other file.

## Screenshots and Usage

https://github.com/dvingerh/yt-dl-protocol/assets/8366383/7102c351-7ad0-4144-be48-7679c61c9f55

![image](https://raw.githubusercontent.com/dvingerh/yt-dl-protocol/main/AppImages/1.png)


![image](https://raw.githubusercontent.com/dvingerh/yt-dl-protocol/main/AppImages/2.png)


![image](https://raw.githubusercontent.com/dvingerh/yt-dl-protocol/main/AppImages/3.png)



### Bookmarklet

1. Navigate to any webpage you want to download media from.
2. Click the bookmark in your bookmarks bar.
3. The current URL will be opened with the `ytdl://` protocol, and the C# backend application will start downloading the media content (if supposed).
**Tip** You can open a new tab, type `ytdl://` yourself and an URL of choice before hitting <kbd>Enter</kbd>. This will also trigger a download.

### Simple GUI
1. When the download request is received by the utility, it'll get right started with your request. An interface will be shown displaying the approximate progress of the downloaded media file.

## Compatibility

- The bookmarklet should work in most modern web browsers, including Chrome, Firefox, Safari, and Edge.

## Contributing

Contributions are welcome! If you have suggestions or improvements, feel free to create an issue or submit a pull request.

## License

I will be adopting the UnLicense.



