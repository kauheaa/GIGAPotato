# Team GIGAPotato
### File structure, hierarchy and asset naming

Guidelines for keeping the project organized and easy to manage.

## Version control
After cloning the repository
1. Create a branch with your name. This is the branch you'll be working on and where you push changes.
3. When making changes to existing scenes or prefabs, post on `#github` to inform others what you're working on, so they know not to touch it before you're finished.
4. Avoid making changes to the same scenes or prefabs at the same time with others.
5. Remember to commit changes regularly to avoid massive commits. Push the commits when you have finished working on a subject and tested it works fine.
6. Post on `#github` when you push, so others know to keep their branches up to date.
7. Merge with others' branches regulargly to keep up to date and avoid conflicts.
8. After merging branches, test your game to see if everything works. Report bugs to Discord so others know not to merge theirs before the issue is solved.

## Asset naming

`PascalCase` is used for all naming.

No spaces or hyphens on file or directory names.

Use descriptive names, in English.

Try to use full words instead of abbreviations unless the name would be super long so it's hard to see parts of it on project.

-	Only use underscores for different aspects of same thing:
    -	`StartButton_Active` `StartButton_Inactive`
    -	`TitleBox_TopLeft`, `TitleBox_Top`, `TitleBox_TopRight`

- Use descriptive words instead of numbering:
    - `StartButton_Hover` instead of `StartButton_2`

-	Only use numbering for objects that form sequences
    -	`PathPoint_01`, `PathPoint_02`, `PathPoint_03`...

## Directory Structure
Nothing should be placed in `Assets` folder except subfolders. If your thing doesn't have

```
Assets
+---Animations
|   +---Characters
|   +---Environment
|   +---Objects
|   +---Placeholders
|   +---UI
+---Animators
|   +---Characters
|   +---Environment
|   +---Objects
|   +---UI
+---Audio
|   +---AudioClips
|   +---AudioMixers
+---Effects
|   +---ParticleEffects
|   +---ParticleMaterials
+---Prefabs
|   +---Characters
|   +---Environment
|   +---MathTasks
|   +---Objects
|   +---TestPrefabs
|   +---UI
+---Scenes
|   +---Levels
|   +---TestScenes
|   +---UI
+---Scripts
|   +---TestScripts
|   +---Math (or smth)
+---Sprites
|   +---Characters
|   +---Environment
|   +---Objects
|   +---Placeholders
|   +---UI
```

## Hierarchy Structure
### Scene
```
Scene
+---Camera
+---Gameplay
|   +---Characters
|   +---Objects
|   +---MathTasks
+---UI
|   +---GUI
|   +---StickerBook
+---Management
+---World
|   +---BackgroundObjects
```

### Characters using same animations
All characters with same animation should same hierarchy. All characters' parts should be named the same and placed in same locations related to the parent. Animator is placed in parent object. (duplicate the original and replace sprites of all parts to create more) 

Example:

```
Dog             /this object is located wherever it is needed/
+---Character   /this object should be located at 0,0,0/
|   +---Head    /this and all below this should be located in relation to the parent/
|   |   +---Hat
|   |   |   +---LeftEye 
|   |   |   +---RightEye
|   |   |   +---Mouth
|   +---Body
|   |   +---LeftArm
|   |   +---RightArm
|   |   |   +---Tool
|   |   +---LeftLeg
|   |   +---RightLeg
|   |   +---Tail
```

## Important

- Use named gameObjects as scene "folders". Duplicates of same objects in scene should be found under the same "folder". All "folder" objects should be located in 0,0,0 with scale 1,1,1 and no rotation.
- Check that everything that is added to a scene starts from location 0,0,0 with scale 1,1,1 and no rotation. Pay attention to z-index, it's rarely supposed to be other than 0.
- Do not use object scale for resizing sprites (unless it's for animating). All objects should start from 1,1,1 scale. If you have to resize sprite in Unity, change Pixels Per Unit from import settings.
