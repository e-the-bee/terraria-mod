# Tasks

Tasks live in the repo's Issues tab on GitHub, one issue per task. Open it from the repo page, or use the project's Issues link. Each task has one owner, called the assignee. An issue with no assignee is free to take.

## Finding something to do

Open Issues, filter by label (`art`, `music`, `sfx`, `code`, `docs`), and look for issues with nobody assigned. `priority: high` means do it soon.

## Taking a task

1. Open the issue and click Assignees on the right, then choose yourself.
2. Tell the team in chat.
3. Make a branch for it ([BRANCHES.md](BRANCHES.md)).

If you stop working on a task, unassign yourself so someone else can pick it up.

## Finishing a task

Write `Closes #12` (with the real number) in the description of your Pull Request. When the PR is merged, GitHub closes the issue for you. You don't tick anything off by hand.

## Adding a task

1. Issues > New issue > Task.
2. Pick the area and describe it so a stranger could pick it up: what it is, how big, where it goes. "Make more enemies" is too vague. "Cave bat enemy sprite, 16x16, 2 wing frames" works.
3. If you don't know a detail, write TBD and link the TBD issue ([TBDS.md](TBDS.md)).

The area label is added for you. Add `priority: high` or `priority: low` from the Labels box if it matters. A task should take hours to a few days, so split anything bigger.

## TODOs in code

```csharp
// TODO(#12): what's left
```

Use the issue number. If there isn't an issue yet, make one first, so people who don't read code can see it.
