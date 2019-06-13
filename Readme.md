
The PictureEdit control provides a built-in editor that allows users to perform basic graphic operations on a current image.
  - Crop and straighten
  - Adjust brightness, contrast and saturation
  - Mirror
  - Rotate
  - etc.

This example shows how to extend the editor with custom graphic commands that add watermarks to the current image.

The steps to add a WatermarkCommand (and other commands) to the image editor are as follows.

1. Create a new class (WatermarkGraphicOperation) that performs an operation on an image. 
The operation must be a BaseCachedGraphicOperation descendant.

2. You can allow users to customize the operation's settings in a custom panel with controls before the operation is applied. 
The panel must implement the IToolSettingsControl interface. The IToolSettingsControl.GetOperation method must return the customized graphic operation (WatermarkGraphicOperation).
This example creates a user control (WatermarkToolControl) with controls to enter the watermark-aware settings:
    - a TextEditor to enter the watermark text
    - a ColorEditor to specify the font color
    - a SpinEditor to enter the font size
    - a CheckEditor to allow the watermark text to be repeated throughout the image.

3. Handle the PictureEdit.ImageEditorDialogShowing event to add custom commands (buttons) to the editor's main toolbar.
In the example two commands are added:
    - WatermarkPreset - Invokes the WatermarkGraphicOperation with predefined settings.
    - WatermarkCommand - Displays the WatermarkToolControl in which users can specify custom watermark settings and then apply the WatermarkGraphicOperation.

