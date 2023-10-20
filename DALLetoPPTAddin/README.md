# DALL-E to PowerPoint Add-In

## Introduction
Welcome to the DALL-E to PowerPoint add-in, a seamless integration that allows users to directly generate and insert AI-created images from DALL-E into their PowerPoint presentations. Make your presentations come alive with state-of-the-art AI imagery!

## Features
- On-the-fly Image Generation: Create images based on textual descriptions without leaving PowerPoint.
- Easy to Use: Simple user interface integrated into PowerPoint's ribbon.
- Customizable Outputs: Adjust the image settings to suit your presentation needs.
- Quick Insert: Add generated images directly into your slides with a double click.

## Installation
1. Download the DallE2PPT<v.xxx>.zip from the releases page.
2. Extract the zip contents and run Setup. 
3. You should now see the DALL-E in the Addins tab.

**Note:** Make sure you close PowerPoint before running the setup  

## How to Use
1. Open PowerPoint and create or open a presentation.
2. Click on the Add-ins tab in the ribbon. You should see "Dall.E 2 PPT" group.
3. Click on "Dream Image" and enter your desired image description in the input box (you can double click to clear the text in the prompt box).
4. Adjust the number for creations you want.
5. Click "Submit" to send your prompt to Dall.E model to create your image. 
6. Double click on any image to insert it into your current slide.

![Dall.E to PowerPoint](/images/Dalle2PPT.png)


## Requirements
Make sure you go to OpenAI.com to get your API key
Microsoft PowerPoint 2016 or newer.
Internet connection for image generation.

## Troubleshooting
If the add-in isn't visible, ensure it's enabled in PowerPoint Add-Ins options.
Make sure you have an active internet connection for seamless image generation.

## Feedback and Contributions
We love to hear from you! If you encounter any issues, have feature requests, or want to contribute, please open an issue on our GitHub page.

### TODO: wish list
- New settings dialog to set the API & resolution options
- Options to choose e.g. Resolutions & change costing per resolutions. Currently by default its at 256x256 resolution 
- Dropdown/checkbox for design styles 

## License
This project is licensed under the MIT License - see the LICENSE.md file for details.