# Getting started

## What git is

Git keeps a history of a folder. Instead of `sprite_final_v2_REAL.png`, it remembers every version, and it lets several people work at once without overwriting each other.

## Words you'll run into

| Word | Meaning |
|------|---------|
| Repository (repo) | The project folder plus its full history. |
| Remote / origin | The shared online copy, on GitHub. |
| Clone | Download the repo to your computer the first time. |
| Branch | Your own copy of the project to work in without touching anyone else's. |
| Commit | A saved snapshot with a short note on what changed. |
| Stage | Pick which changed files go into the next commit. |
| Push | Upload your commits to the remote. |
| Pull / Fetch | Download other people's new commits. |
| Pull Request (PR) | A request to merge your branch into `main` after someone reviews it. |
| Merge | Combine one branch into another. |
| Conflict | Two people changed the same thing and git needs a human to pick. |

## One-time setup in GitKraken

1. Open GitKraken and sign in. GitHub login is the easiest.
2. File > Clone Repo > GitHub.com. Pick this project, choose a folder on your computer, click Clone.
3. Set your name and email under Preferences > Profiles. They appear on your commits, so use a name the team recognizes.

You'll see the project as a graph of dots. Each dot is a commit. The left panel lists branches, and the right panel shows changed files once you click the WIP row at the top of the graph. The commit box is at the bottom right.

## Each time you work

1. Click Fetch, check out `main`, and Pull.
2. Make your branch ([BRANCHES.md](BRANCHES.md)).
3. Work in your usual program (Aseprite, Photoshop, your DAW) and save into the repo folder.
4. In GitKraken, click the WIP row, stage your files, write a message and commit ([COMMITS.md](COMMITS.md)).
5. Push.
6. Open a Pull Request and ask someone to review it.

## Things that go wrong

Pull before you start, every time. Old copies cause most conflicts.

Images and audio can't be merged automatically. If two people edit the same PNG, one person's work is lost. Say in chat which file you're touching.

Close your art or audio program before committing, so the file on disk is complete.

Don't delete the `.git` folder or move the repo while GitKraken is open.

If you make a mistake, don't fix it by deleting things. Ask, or right-click the commit in GitKraken and choose Revert.

You can ignore rebase, cherry-pick, stash, force push and reset for now. If a tutorial tells you to use one, check with the team first.
