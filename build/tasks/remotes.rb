desc "Set up the remote link to JP's repository"
task :remotes do
  `git remote rm jp`
  `git remote add jp git://github.com/developwithpassion/provt.git`
end
