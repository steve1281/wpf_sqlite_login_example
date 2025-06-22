WPF /SQLite Login Tutorial

based on: https://www.youtube.com/watch?v=X2AksMwYyss by Tactic Devs
(I am not associated with, but recommend watching the video)

Application is a very simple SQLite login screen.  You will need to run it once to generate the Datbasedb file. Oce that is done, you will need to edit the database file with _DB Browser for SQLite__ or equivalent.
You can access this tool at: https://sqlitebrowser.org

Also, the tutorial doesn't explain how to setup the project, or in fact any of the UI. It's not hard; stuggle through it.

You will need to add libs:

NUGETs:
- Microsoft.EntityFrameworkCore.Sqlite


Notes:
- I ran into an error while following tutorial; it started talking about SQLitePCL.Batteries. If this happens, drop the nugs the video suggests and add just the one from above.

