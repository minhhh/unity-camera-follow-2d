# unity-camera-follow-2d
Script to make 2d camera follow players in an interesting way.

## Usage
Add the script `FollowCamera2D` to your camera then set the appropriate parameters.

* `Target` - The transform object to follow.
* `Damp Time` - The time it took for the camera to follow the target. Default to 0.15 (seconds).
* `Follow Type` - Which direction to follow the target: None, Horizontal, Vertical or Both.
* `Camera Center X`, `Camera Center Y` - The position in view port coordinates that the camera should track by. Default is 0.5, 0.5, which is the center of the camera. If you want the target to appear at one third on the left of the camera you can use 0.33, 0.5.
* `Bound Type` - Specify if the camera should be bound or not. It can be `None` - unbounded camera, `Horizontal` - Camera bounded left and right, `Vertical` - Camera bounded top and bottom, and `Both` - Camera bounded both horizontally and vertically.
* `Left Bound`, `Right Bound` - Horizontal bounds of the camera. This is the coordinate which the camera left edge and right edge should not pass, respectively. These are only activated if `Bound Type` is `Horizontal` or `Both`.
* `Lower Bound`, `Upper Bound` - Vertical bounds of the camera. This is the coordinate which the camera left edge and right edge should not pass, respectively. These are only activated if `Bound Type` is `Vertical` or `Both`.
* `Dead Zone Type` - Deadzone as in Mario camera. It can be `None` - no dead zone. `Horizontal` - horizontal dead zone which activates when moving left or right. `Vertical` - vertical deadzone which activates when moving up or down.
* `Hard Dead Zone` - If `Hard Dead Zone` is True, the camera moves like Mario, i.e, inside the dead zone it would not track the target's movement, only when going to the edge then the camera follows the target. If `Hard Dead Zone` is False, then even inside the dead zone the camera still follows the target normally. Default to False.
* `Left Dead Bound` - The number of unit in world coordinate to the left of the center of the camera that the target should not pass.
* `Right Dead Bound` - The number of unit in world coordinate to the right of the center of the camera that the target should not pass.
* `Upper Dead Bound` - The number of unit in world coordinate to the top of the center of the camera that the target should not pass.
* `Lower Dead Bound` - The number of unit in world coordinate to the bottom of the center of the camera that the target should not pass.

The follow function itself uses `Vector3.SmoothDamp` function. This has some easing effect, thus performing better than the `Vector3.Lerp` linear function.

You can use the `TestScene` scene for some test with the camera script.

## Other notes
* If your camera jitter then try setting the target's rigidbody `Interpolate` to `Interpolate` instead of `None`
* If your camera still jitter then try reducing the speed.

## License
MIT © [Minh Ha](https://github.com/minhhh)
