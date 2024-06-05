##### This is a project in progress. There may be bugs, glitches, and other unexpected behavior. Consider reporting these if you can.

## yt-dl-protocol

Use a bookmarklet to quickly download media content from the current webpage URL using a custom `ytdl://` protocol and `youtube-dl`. The bookmarklet communicates with a small, locally run C# utility that relies on `youtube-dl` to handle downloads. 

- **Wide Support**: This utility relies on [youtube-dl]([youtube-dlp](https://github.com/yt-dlp/yt-dlp)), so hundreds of websites are supported.
- **Instant Downloads**: Download any media with a single click on the bookmarklet, the utility handles the rest.
- **Simple Setup**: Set up the utility using the simple interface and add the bookmarklet to your browser's bookmarks bar.
- **No Background Processes**: This utility does not run in the background, ensuring that system resources are used only when necessary.

## Requirements
- .NET Framework 4.8.1 (available [here](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net481-offline-installer)) or greater.
- `youtube-dl` or `yt-dlp` (available [here](https://github.com/yt-dlp/yt-dlp)).
- Administrator privileges (changes will be made to the computer registry, which is required to register the protocol).

## Setup

1. Open the interface by simply opening the executable the way you would any other file.
2. Select your `youtube-dl` executable path, download path and register the protocol. Save your settings.
3. Start creating a new bookmarklet in your web browser and give it a suitable name, such as `Download with yt-dl`.
4. Copy the following JavaScript code from here or from the utility's interface:

    ```javascript
    javascript:(function(){var currentURL=window.location.href;var ytdlURL='ytdl://'+currentURL;window.open(ytdlURL,'_self');})();
    ```

5. Paste the copied JavaScript code into the URL or "Location" field of the bookmarklet.
6. Save the bookmarklet.

## Usage

1. Navigate to any webpage you want to download media from.
2. Click the bookmarklet in your bookmarks bar.
3. The current URL will be sent to the utility and will start downloading any available media content on the website.
**Tip**: You can open a new tab, type `ytdl://` following a URL of choice before hitting <kbd>Enter</kbd>. This will also trigger a download.

## Screenshots & Demo

https://github.com/dvingerh/yt-dl-protocol/assets/8366383/7102c351-7ad0-4144-be48-7679c61c9f55

![image](https://raw.githubusercontent.com/dvingerh/yt-dl-protocol/main/AppImages/1.png)

![image](https://raw.githubusercontent.com/dvingerh/yt-dl-protocol/main/AppImages/2.png)

![image](https://raw.githubusercontent.com/dvingerh/yt-dl-protocol/main/AppImages/3.png)


## Contributing

Contributions are welcome! If you have suggestions or improvements, feel free to create an issue or submit a pull request.

## License

I will be adopting the UnLicense.
