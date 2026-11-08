# TBDs

TBD means "to be decided." If you need a decision that doesn't exist yet, write TBD instead of guessing. A silent guess gets baked into the work and costs more to undo later.

Every TBD also goes in the register, [TBD.md](../TBD.md) in the project root, as a question someone can answer. Keep working with a placeholder while you wait, and close the entry when it's decided.

## Where to write one

| Where | How |
|-------|-----|
| Docs and TODOs | Plain text: `Boss HP: TBD` |
| Code | `// TBD(name): question` |
| File names | Avoid. Use a placeholder name and add a register entry. |
| Register | [TBD.md](../TBD.md), always. |

## Register columns

IDs count up and are never reused. Write the question so it can be answered with a choice. "Needed by" says when it starts blocking someone, either an event ("before boss art") or a date. Status is Open, Decided or Dropped.

## Placeholders

Make them obvious so nobody mistakes them for finished work. Use a flat colored box or `Placeholder_<Thing>.png` for art, `Placeholder_<Thing>.ogg` for a rough music loop, and `[PLACEHOLDER]` in text.

## Resolving one

1. Talk it over in chat. The maintainer, or the group, makes the call.
2. In `TBD.md`, move the entry from Open to Decided and record the answer and date.
3. Replace the TBD text and placeholders. Search the project for `TBD(` and `TBD-` to find them.
4. Commit with a message like `docs: decide item sprite size (TBD-001)`.
