# OpenARMenus

[![CodeFactor](https://www.codefactor.io/repository/github/appdevelopmentandsuch/openarmenus/badge)](https://www.codefactor.io/repository/github/appdevelopmentandsuch/openarmenus)
[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://GitHub.com/appdevelopmentandsuch/OpenARMenus/graphs/commit-activity)
[![GitHub license](https://img.shields.io/github/license/appdevelopmentandsuch/OpenARMenus.svg)](https://github.com/appdevelopmentandsuch/OpenARMenus/blob/master/LICENSE)
[![GitHub release](https://img.shields.io/github/release/appdevelopmentandsuch/OpenARMenus.svg)](https://GitHub.com/appdevelopmentandsuch/OpenARMenus/releases/)
[![GitHub tag](https://img.shields.io/github/tag/appdevelopmentandsuch/OpenARMenus.svg)](https://GitHub.com/appdevelopmentandsuch/OpenARMenus/tags/)
[![Github all releases](https://img.shields.io/github/downloads/appdevelopmentandsuch/OpenARMenus/total.svg)](https://GitHub.com/appdevelopmentandsuch/OpenARMenus/releases/)
[![GitHub stars](https://img.shields.io/github/stars/appdevelopmentandsuch/OpenARMenus.svg?style=social&label=Star&maxAge=2592000)](https://GitHub.com/appdevelopmentandsuch/OpenARMenus/stargazers/)
[![GitHub issues](https://img.shields.io/github/issues/appdevelopmentandsuch/OpenARMenus.svg)](https://GitHub.com/appdevelopmentandsuch/OpenARMenus/issues/)
[![GitHub issues-closed](https://img.shields.io/github/issues-closed/appdevelopmentandsuch/OpenARMenus.svg)](https://GitHub.com/appdevelopmentandsuch/OpenARMenus/issues?q=is%3Aissue+is%3Aclosed)

## Fully customizable, easy to use, menus for Unity

(Collision detection coming soon!)

![Demo Image 1](https://user-images.githubusercontent.com/73759882/97790159-457f1c00-1b94-11eb-9707-1393acb7e711.png)
![Demo Image 2](https://user-images.githubusercontent.com/73759882/97790161-46b04900-1b94-11eb-8d9c-12c18a83140e.png)
![Demo Image 3](https://user-images.githubusercontent.com/73759882/97790163-46b04900-1b94-11eb-8bf8-bfd8450c5e2c.png)
![Demo Image 4](https://user-images.githubusercontent.com/73759882/97790164-4748df80-1b94-11eb-96cd-bb683febe6fd.png)

## Getting Started

Download and import the Unity package found [here](https://github.com/appdevelopmentandsuch/OpenARMenus/blob/master/UnityPackages/OpenARMenus.unitypackage)

## Usage

### Basic 2D Config and Customization

![Basic-2D-config](https://user-images.githubusercontent.com/73759882/97790529-3d74ab80-1b97-11eb-8b23-9d2313292e8a.gif)
![2D-customization](https://user-images.githubusercontent.com/73759882/97790526-39488e00-1b97-11eb-91d0-dd4e3d15e42f.gif)

### Basic 3D Config and Customization

![Basic-3D-config](https://user-images.githubusercontent.com/73759882/97790530-3fd70580-1b97-11eb-86b8-1750d6a20118.gif)
![3D-customization](https://user-images.githubusercontent.com/73759882/97790528-3b125180-1b97-11eb-82d5-73a206e24129.gif)

- The easiest way to get started is to drag and drop a 2D / 3D menu prefab into your scene.
- Once in the scene, you can set the color, and images of your menu. You can create and import your own menu images, or use the ones provided in the package.

## Customization

### 2D Menu

| Variable                  | Type   | Is Override | Default Value | Notes                                                                                                                                     |
| ------------------------- | ------ | ----------- | ------------- | ----------------------------------------------------------------------------------------------------------------------------------------- |
| Width                     | Int    | No          | 200           | The Width of the menu. This will determine the dimensions required for the box collider bounding box.                                     |
| Height                    | Int    | No          | 200           | The Height of the menu. This will determine the dimensions required for the box collider bounding box.                                    |
| Menu Color                | Color  | No          | Color.clear   | The color of the menu outline and background. If not changed from Color.clear, it will be set to Color.white                              |
| Menu Image Color          | Color  | Yes         | Color.clear   | The color of the menu outline. If not changed from Color.clear, it will be set to Color.white. This can be used to override Menu Color    |
| Menu Image Filled Color   | Color  | Yes         | Color.clear   | The color of the menu background. If not changed from Color.clear, it will be set to Color.white. This can be used to override Menu Color |
| Menu Image Filled Opacity | Float  | No          | 0.3           | The menu's filled image opacity                                                                                                           |
| Menu Image                | Sprite | No          | None          | The menu outline image.                                                                                                                   |
| Menu Image Filled         | Sprite | No          | None          | The filled menu image.                                                                                                                    |

### 3D Menu

| Variable                        | Type   | Is Override | Default Value | Notes                                                                                                                                                       |
| ------------------------------- | ------ | ----------- | ------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Width                           | Int    | No          | 200           | The Width of the menu. This will determine the dimensions required for the box collider bounding box.                                                       |
| Height                          | Int    | No          | 200           | The Height of the menu. This will determine the dimensions required for the box collider bounding box.                                                      |
| Background Scale                | Float  | No          | 1.2           | The scale of the back of the 3D menu                                                                                                                        |
| Background Distance             | Int    | No          | 20            | The distance between the Menu Front and Menu Back                                                                                                           |
| Menu Color                      | Color  | No          | Color.clear   | The color of the menu outline and background. If not changed from Color.clear, it will be set to Color.white                                                |
| Menu Image Color                | Color  | Yes         | Color.clear   | The color of the menu outline. If not changed from Color.clear, it will be set to Color.white. This can be used to override Menu Color                      |
| Menu Image Filled Color         | Color  | Yes         | Color.clear   | The color of the menu background. If not changed from Color.clear, it will be set to Color.white. This can be used to override Menu Color                   |
| Main Image Color                | Color  | Yes         | Color.clear   | The color of the menu's main pane outline. If not changed from Color.clear, it will be set to Color.white. This can be used to override Menu Color          |
| Main Image Filled Color         | Color  | Yes         | Color.clear   | The color of the menu's main pane background. If not changed from Color.clear, it will be set to Color.white. This can be used to override Menu Color       |
| Background Image Color          | Color  | Yes         | Color.clear   | The color of the menu's background pane outline. If not changed from Color.clear, it will be set to Color.white. This can be used to override Menu Color    |
| Background Image Filled Color   | Color  | Yes         | Color.clear   | The color of the menu's background pane background. If not changed from Color.clear, it will be set to Color.white. This can be used to override Menu Color |
| Main Image Filled Opacity       | Float  | No          | 0.3           | The menu's main image filled opacity                                                                                                                        |
| Background Image Filled Opacity | Float  | No          | 0.3           | The menu's background image filled opacity                                                                                                                  |
| Menu Image                      | Sprite | No          | None          | The menu outline image.                                                                                                                                     |
| Menu Image Filled               | Sprite | No          | None          | The filled menu image.                                                                                                                                      |
| Main Image                      | Sprite | Yes         | None          | The menu's main pane outline image.                                                                                                                         |
| Main Image Filled               | Sprite | Yes         | None          | The menu's main pane filled image.                                                                                                                          |
| Background Image                | Sprite | Yes         | None          | The menu's background pane outline image.                                                                                                                   |
| Background Image Filled         | Sprite | Yes         | None          | The menu's background pane filled image.                                                                                                                    |
