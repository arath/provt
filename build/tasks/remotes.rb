desc "Sets up the remotes to jp"
task :remotes do
  `git remote rm jp`
  `git remote add jp git://github.com/developwithpassion/prov.git`
end
