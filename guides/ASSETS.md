# Assets

For artists and musicians. Anything the game loads lives inside the mod folder, `code/Example/`, so tModLoader can find it.

The layout, sizes and formats below are a proposal. Anything not yet agreed is marked TBD and tracked as an issue ([TBDS.md](TBDS.md)).

## Folders

```
code/Example/Assets/
  Items/         item sprites         Items/LavaSword.png
  NPCs/          enemy and boss art   NPCs/SlimeBoss.png
  Projectiles/
  Tiles/         blocks and furniture
  UI/
  Music/         Music/ForestTheme.ogg
  Sounds/        Sounds/SwordSwing.wav
```

Create a folder if it doesn't exist yet.

## File names

Use PascalCase with no spaces or special characters: `LavaSword.png`, not `lava sword (final).png`. Name the file for what it is. Variants take a suffix (`LavaSword_Glow.png`), and spritesheets end in `_Sheet` (`SlimeBoss_Sheet.png`). No version numbers, since git already keeps the versions.

## Sprites and spritesheets

PNG with transparency. If you scale, use nearest-neighbor so edges stay sharp. Frame size, frame count, padding and palette are TBD, so settle them before anyone draws a lot of art.

Stack frames in a vertical strip unless a coder asks otherwise, because tModLoader animations expect that. In your PR, say the frame size, the number of frames and what the sprite is for.

## Music and sound

Music is `.ogg`, which stays small and loops well in tModLoader. Sound effects can be `.wav` or `.ogg`. Check that the end of a song flows back into the start. Peak around -3 dB and avoid clipping so volumes match across tracks.

Credit any sample or borrowed material in your PR description, and only use material you have the right to use.

## Source files

Ask before committing `.aseprite`, `.psd`, `.flp` or `.als` files. The default plan is to keep them on a shared drive and commit only the exported game-ready file.

## Before you open a PR

- Files are in the right folder with correct names and formats.
- You've attached a screenshot or audio clip.
- Only files for this task are staged.
- Anything undecided is marked TBD and has an issue ([TBDS.md](TBDS.md)).
- The PR description says `Closes #N` for the task it finishes.
