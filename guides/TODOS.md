# TODOs

There's one shared list and every task has one owner. The list is [TODO.md](../TODO.md) in the project root. Edit it through a branch and PR like any other file.

## Task format

```
- [ ] [area] Description (@owner) {priority}
```

`[ ]` is open and `[x]` is done. Area is `art`, `music`, `sfx`, `code` or `docs`. Priority is `high`, `med` or `low`, and defaults to `med`. A task with no owner is free to take.

```
- [ ] [art] Slime boss idle spritesheet, 4 frames (@sam) {high}
- [ ] [music] Forest biome theme, 90 seconds, loops
- [x] [docs] Write branch guide (@donovan)
- [ ] [sfx] Sword swing sound (@alex) {low}
```

## Taking a task

Add your `@name` to it on a branch (for example `docs/claim-slime-boss-task`) or ask the maintainer to assign it, then tell the team in chat. Do the work on its own branch ([BRANCHES.md](BRANCHES.md)).

## Finishing a task

Change `[ ]` to `[x]` in the same PR as the work, so the reviewer sees the task and the result together. If you stop working on a task, remove your name.

## Adding a task

Write it so a stranger could pick it up: what it is, how big, where it goes. "Make more enemies" is too vague. "Cave bat enemy sprite, 16x16, 2 wing frames" works. If you don't know a detail, write TBD ([TBDS.md](TBDS.md)).

A task should take hours to a few days. Split anything bigger.

## TODOs in code

```csharp
// TODO(name): what's left
```

Also add it to `TODO.md` so people who don't read code can see it.

The list has four sections: In progress, Up next, Backlog / ideas, and Done.
