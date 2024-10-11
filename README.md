# unity-discord
Send messages to your [Discord](https://discord.com) channel via [webhooks](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks).

## Installation
Download the entire repository from https://github.com/lumpn/unity-discord and use Unity's built in package manager to [Add package from disk](https://docs.unity3d.com/Manual/upm-ui-local.html).

## Usage
```csharp
public WebhookData webhookData;

IEnumerator Start()
{
    var webhook = webhookData.CreateWebhook();
    return webhook.Send("Hello, World!");
}
```

## Creating a webhook
Follow Discord's guide to [creating a webhook in Discord](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks), then copy the webhook URL, create a `WebhookData` asset, and paste the webhook URL into the `WebhookData` asset.

![Copy Webhook URL](https://support.discord.com/hc/article_attachments/360101553853/Screen_Shot_2020-12-15_at_4.51.38_PM.png)

## Samples
Samples are included in the package. Install them via Unity's package manager.

```csharp
public WebhookData webhookData;

IEnumerator Start()
{
  var embed = new Embed()
      .SetColor(color)
      .SetTitle(title)
      .SetAuthor(author, authorIconUrl)
      .SetDescription(description)
      .SetThumbnail(thumbnailUrl)
      .SetImage(MediaType.PNG, imageBytes)
      .SetFooter(footer, footerIconUrl);

  var webhook = webhookData.CreateWebhook();
  return webhook.Send(embed);
}
```

![Unity Discord](https://github.com/user-attachments/assets/7604288f-a4f0-4311-80d4-c8a5e8481593)
