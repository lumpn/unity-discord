# unity-discord
Send messages to your [Discord](https://discord.com) channel via [webhooks](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks).

## Installation
Download the entire repository from https://github.com/lumpn/unity-discord and use Unity's built in package manager to [Add package from disk](https://docs.unity3d.com/Manual/upm-ui-local.html).

## Usage
```csharp
    public WebhookData webhookData;

    void Start()
    {
        var webhook = webhookData.CreateWebhook();
        webhook.Send("Hello World!");
    }
```

## Creating a webhook
Follow Discord's guide to [creating a webhook in Discord](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks), then copy the webhook URL, create a `WebhookData` asset, and paste the webhook URL into the `WebhookData` asset.

![Copy Webhook URL](https://support.discord.com/hc/article_attachments/360101553853/Screen_Shot_2020-12-15_at_4.51.38_PM.png)

## Samples
See `Samples` for details.
