# Branches

A branch is your own workspace. Your changes stay on it until someone reviews them and merges them into `main`.

Never commit directly to `main`, because it should always work. Make one branch per task and keep it short, days rather than weeks. Always branch from an up-to-date `main`, and delete the branch once it's merged.

## Naming

Use `type/short-description`: lowercase, words joined by dashes, no spaces.

| Type | For | Example |
|------|-----|---------|
| `art/` | Sprites, spritesheets, icons, UI art | `art/slime-boss-spritesheet` |
| `music/` | Songs and loops | `music/forest-theme` |
| `sfx/` | Sound effects | `sfx/sword-swing` |
| `code/` | Programming | `code/add-boss-spawn` |
| `docs/` | Guides and design notes | `docs/boss-lore` |
| `fix/` | Repairs | `fix/torch-sprite-clipping` |

`art/lava-sword-icon` works. `new-stuff` and `Final_v2` don't.

## Starting a branch in GitKraken

1. Double-click `main` in the left panel to check it out.
2. Click Pull in the top bar.
3. Click Branch in the top bar, type the name and press Enter. GitKraken switches to it for you.

Commit as you go ([COMMITS.md](COMMITS.md)). The first time you Push, push to `origin`. After that, Push just works.

## Opening a Pull Request

1. Right-click your branch in the left panel and choose "Start a pull request to origin/main".
2. Give it a title saying what you did, plus a couple of lines of description. If it finishes a task, add `Closes #12` (the issue number) so GitHub closes the issue when the PR merges. Attach a screenshot or an audio clip if you have one.
3. Ask someone in chat to review it.

Anyone except the author can review. The maintainer does the merge.

## After the merge

Check out `main`, Pull, then right-click your old branch and Delete it.

## Long-running branches

If a task runs past a couple of days, Fetch, then right-click `origin/main` and choose "Merge origin/main into" your branch. If a conflict shows up, stop and ask for help.
