What is VCS?
-> VCS stands for Version Control System, which is a software tool that helps software teams manage changes to source code over time.

What is git?
Git is a version control system that lets you manage and keep track of your source code history

When do we use git/Why is git important?
Git tracks the changes you make to files, so you have a record of what has been done, and you can revert to specific versions should you ever need to. Git also makes collaboration easier, allowing changes by multiple people to all be merged into one source.

How is git different from github?
Git is a version control system, GitHub is a hosting service that lets you manage Git repositories.

What is repository?
A Git repository is is a central storage location for managing and tracking changes in files and directories. There is a .git/ folder inside a project. This repository tracks all changes made to files in your project, building a history over time. Meaning, if you delete the .git/ folder, then you delete your project’s history.

How do we tell when a folder is git repository or not?
if there is a .git/ folder -> it is a repo

What's the difference between remote and local repository?
Remote repo stored on services like github, local is the one on your machine

What is cloning?
It is making a copy of a repo on your local machine from GitHub

What is staging?
Is instructing Git to track changes to the file in preparation for a commit.

What is committing?
Is used to save your changes to the local repository. The git commit command captures a snapshot of the project's currently staged changes

how do I look at my commit history?
git log command with the branch name shows the commit history for the branch currently checked out. Or you can navigate directly to the commits page of a repository on Github

What is pulling?
The git pull command is used to fetch and download content from a remote repository and immediately update the local repository to match that content

What is pushing?
The git push command is used to upload local repository content to a remote repository

Describe the basic git workflow
1. create a repo on Github
2. clone the repo to local machine
3. create new branch
4. make some changes
5. stage, and commit
6. pull most recent version to your local machine
7. resolve conficts if any
8. push your changes
9. merge your branch with main on github


What are branches, and why are they important?
branch is a new/separate version of the main repository. Branches allow you to work on different parts of a project without impacting the main branch.

What is merging?
Git merge is combining the changes in one branch with another branch.

What is a Pull Request?
Is a proposal to merge changes from one branch of a repository into another.

What are some recommended practices when working with others?
1. Make sure you you pull latest version
2. make sure you are in the right branch
3. commit every change you do
4. ask someone to review your changes before merging to prevent bugs

(T/F) It is recommended to push directly to main especially when working in a team project
Never push to main branch. push you new brach, create merge request and ask for review