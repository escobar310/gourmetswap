
## Chat Bot for Gourmet Swap
Personally launched an intelligent chat bot to enhance and improve users interactions, experience, and meal searches. Designed conversations to support freeform and more guided interactions through simple text to complex rich cards that contain text, images, and action buttons.

Code is written in C# / ASP.NET using Microsoft's Cognitive Services (Language Understanding Intelligent Service aka LUIS) and Bot Framework.

Under GSwap.Bot/Controllers the Messages Controller can be located. This controller captures user information - message, user name, web client, etc.. - and starts the 'BasicQnAMakerDialog' dialog. The 'BasicQnAMakerDialog' dialog can be found under GSwap.Bot/Dialogs.
