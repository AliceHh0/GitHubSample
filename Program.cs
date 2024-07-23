
/*
 * Working Directory > Staging Area(will be tracked) > Github Repo
 * git init > git add > git commit
 * 
 * 
 * 
 * #################### List of Commands ###########################
 * git init
 * git add -n : -n not to be add but will show if file is exist or ignored
 *         -f : stage all including ignore
 *         .  : stage all except ignored
 *         -A : stage all including subdirectories
 *         filename1 filename2 : stage specific files
 *         
 * git status
 * git diff : to check difference in version (+ is the newly added changes)
 * git commit -m "text" : -m to add messages for commit action
 *            --amend (--no-edit > keep same commit msg)   : commit this and replace the most recent commit ( to keep less commit, and more clean!!)
 * git log : return commit history with a unique identifier called SHA
 *         --oneline : to show in one line
 *         -S keyword(Add/Deletion/Modification) : to filter based on keyword , ex: only related to addition
 *         -- graph - visual representation, can be combine with oneline for simplification
 * git show HEAD : to see the commit at HEAD (the commit that you are currently on)
 * git checkout HEAD filename : update HEAD pointer to another branch, at the same time delete whatever file u working on at working directory, and instead show the file in new pointer
 *                              need to close file, and open back file to see the changes
 * git reset HEAD filename : pointer points same branch, but the commit is discarded, 
 *           commitSHAnumber : remove file from staging area and back to this specific commit
 * git stash : temporarily stash work at working directory, and then use {git stash pop} to retrieve back, can store multiple
 * git stash list : to see git stash
 * 
 * 
 * 
 * #################### Useful Tips ###########################
 * Setting Up Alias [To shorten, shortcut key commands]
 * $ git config --global alias.co "checkout"
 * $ git co filename vs git checkout filename
 * 
 * ctrl+shift+insert to paste in Git Bash
 * 
 * 
 * #################### To Initialize GITHUB ###########################
 * Steps:
 * 1. mkdir git_main_file > make a new directory
 * 2. go to the newly created directory
 * 3. git init
 * 4. create a gitignore file to ignore certain visual studio file
 * 5. git add. to add all files (it will ignore files listed in git ignore)
 * 6. git commit -m "Commit message"
 * 7. Connect local repo to online Github repo (make sure working tree clean, no staging files), by creating a new repo on Github first
 * 8. git remote add origin https://github.com/AliceHh0/git_practice.git to add local repo to the online repo
 * 9. git branch -M main
 * 10. git push -u origin main
 * 
 * 
 * #################### THE CORRECT WAY TO COOP GITHUB ###########################
 * Steps:
 * 1. Create a branch
 * 2. Commit changes
 * 3. Open Pull Request
 * 4. Review Pull Request
 * 5. Merge
 * 6. Delete the non active branch if needed, to keep it clean
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */