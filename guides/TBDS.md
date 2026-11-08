# TBDs

TBD means "to be decided." If you need a decision that doesn't exist yet, write TBD instead of guessing. A silent guess gets baked into the work and costs more to undo later.

Every TBD is an issue with the `tbd` label, written as a question someone can answer. Keep working with a placeholder while you wait. The issue is closed when it's decided.

## Where to write one

| Where | How |
|-------|-----|
| Issues | Issues > New issue > TBD (needs a decision). Always. |
| Docs and tasks | Plain text with the issue number: `Boss HP: TBD (#14)` |
| Code | `// TBD(#14): question` |
| File names | Avoid. Use a placeholder name and open an issue. |

Write the question so it can be answered with a choice. "Needed by" says when it starts blocking someone, either an event ("before boss art") or a date.

## Placeholders

Make them obvious so nobody mistakes them for finished work. Use a flat colored box or `Placeholder_<Thing>.png` for art, `Placeholder_<Thing>.ogg` for a rough music loop, and `[PLACEHOLDER]` in text.

## Resolving one

1. Talk it over in the issue comments or in chat. The maintainer, or the group, makes the call.
2. Write the answer in a comment, then close the issue. The comment is the record of why.
3. Replace the TBD text and placeholders. Search the project for `TBD` to find them.
4. Commit with a message like `docs: decide item sprite size (#14)`.

To see what's still open, filter Issues by the `tbd` label.
