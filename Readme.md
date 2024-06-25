<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/191803279/19.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828675)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WinForms PictureEdit - Add custom graphic operations (watermarks) to the built-in image editor

The WinForms PictureEdit control integrates an image editor that allows users to perform common graphic operations:

* Crop and straighten
* Adjust brightness, contrast, and saturation
* Mirror
* Rotate, etc.

This example shows how to extend the image editor. The example adds custom commands that allow you to watermark the image:

![WinForms PictureEdit - Watermark Images](pictureedit-editor-watermark.png)

1. Create a `BaseCachedGraphicOperation` descendant class (`WatermarkGraphicOperation`). Users can undo and redo BaseCachedGraphicOperations while the image editor is active. See [WatermarkToolControl.cs](./CS/WatermarkDemo/WatermarkDemo/WatermarkToolControl.cs) for implementation details.

2. You can allow users to specify the operation's settings in custom controls before the operation is applied. 
Create a panel with controls and implement the `IToolSettingsControl` interface for the panel. The `IToolSettingsControl.GetOperation` method must return the customized graphic operation (WatermarkGraphicOperation).

   This example creates a user control (WatermarkToolControl) with controls to enter the watermark-related settings:
   
   * TextEditor to enter the watermark text
   * ColorEditor to specify the font color
   * SpinEditor to enter the font size
   * CheckEditor to allow the watermark text to be repeated throughout the image.

3. Handle the [PictureEdit.ImageEditorDialogShowing](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit.ImageEditorDialogShowing) event to add custom commands (buttons) to the editor's main toolbar.

   This example adds two commands:
   
   * WatermarkPreset - Invokes the WatermarkGraphicOperation with predefined settings.
   * WatermarkCommand - Displays the WatermarkToolControl in which users can specify custom watermark settings and then apply the WatermarkGraphicOperation.


## Files to Review

* [WatermarkToolControl.cs](./CS/WatermarkDemo/WatermarkDemo/WatermarkToolControl.cs) (VB: [WatermarkToolControl.vb](./VB/WatermarkDemo/WatermarkDemo/WatermarkToolControl.vb))
* [Form1.cs](./CS/WatermarkDemo/WatermarkDemo/Form1.cs) (VB: [Form1.vb](./VB/WatermarkDemo/WatermarkDemo/Form1.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pictureedit-add-custom-graphic-operation-watermark&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pictureedit-add-custom-graphic-operation-watermark&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
