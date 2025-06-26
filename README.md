WPF /SQLite Login Tutorial

based on: https://www.youtube.com/watch?v=X2AksMwYyss by Tactic Devs
(I am not associated with, but recommend watching the video)

Application is a very simple SQLite login screen.  You will need to run it once to generate the Datbasedb file. Once that is done, you will need to edit the database file with _DB Browser for SQLite__ or equivalent.
You can access this tool at: https://sqlitebrowser.org

Also, the tutorial doesn't explain how to setup the project, or in fact any of the UI. It's not hard; struggle through it.

You will need to add libs:

NUGETs:
- Microsoft.EntityFrameworkCore.Sqlite


Notes:
- I ran into an error while following tutorial; it started talking about SQLitePCL.Batteries. If this happens, drop the nugs the video suggests and add just the one from above.

git log --oneline --decorate --all --reverse

- 1e35fb2 add gitignore
- d261d4b initial project
- ae395ae rough in mainpage and userlogin windows
- 1c84838 add login fields and a button click handler
- 639f8ad set userlogin as startupuri, cleanup mainpage a little
- 8f52ef0 add a readme
- 665b8bd add in suport for sqlite via entityframework
- 3fa2695 add database interface and user class for our table
- a4b2251 add code to create database if it doesn't exist.
- 1ebf754 messing with nugs to get rid of errors; see readme
- bdc5f8c query to see if user is allowed, close window, open main page
- 5c07775 (HEAD -> master) update notes
