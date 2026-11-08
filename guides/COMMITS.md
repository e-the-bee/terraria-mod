# Commits

A commit is a saved snapshot. Its message is how teammates, and you in a month, know what happened without opening every file.

Commit small and often, one idea at a time. Only include files that belong to your task, and check the list before you commit. Leave out temp files, program backups, DAW autosaves, `bin/` and `obj/`.

## Message format

```
type: short summary

Optional longer note on what changed and why.
```

Keep the summary under about 50 characters, in the imperative ("add", not "added"), with no period.

| Type | Meaning |
|------|---------|
| `art` | New or changed sprites, icons, spritesheets |
| `music` | New or changed songs |
| `sfx` | Sound effects |
| `code` | Programming |
| `docs` | Guides and notes |
| `fix` | Repairing a mistake |
| `chore` | Cleanup, renaming, moving files |
| `wip` | Unfinished work saved at the end of a session |

Good:
- `art: add idle animation to slime boss spritesheet`
- `music: fix loop point in forest theme`
- `fix: remove stray pixels from torch sprite`

Bad: `stuff`, `update`, `final version`, `fixed it`.

## Committing in GitKraken

1. Click the WIP row at the top of the graph.
2. In the right panel, click each file under Unstaged Files to preview it.
3. Stage the files for this task. "Stage all changes" is fine if every file belongs.
4. Type the summary, and a description if it needs one.
5. Click Commit changes, then Push.

## When to commit

Commit when a sprite or animation reaches a good checkpoint, when you've exported a song section, and before you try something risky like a new palette. Also commit at the end of a session, even if the work isn't done. Use `wip:` and tell the team.

## Images and audio

Commit the exported files the game reads (`.png`, `.ogg` or `.wav`) in the right folder ([ASSETS.md](ASSETS.md)). Editable source files (`.aseprite`, `.psd`, `.flp`) are large, so ask before adding them.

## Fixing mistakes

- Typo in your latest unpushed message: right-click the commit and choose Reword commit.
- Wrong file already pushed: don't rewrite history. Make a new commit that removes it, like `fix: remove accidental file`.
- Anything else: ask.
