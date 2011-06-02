require 'rake'
require 'rake/clean'
require 'fileutils'
require 'erb'
require 'configatron'

=begin Supplementary Build Files

build\utils - Utilities for the build
build\tasks\configuration.rb - Project specific configuration
build\tasks\machine_specs.rb 
build\tasks\deployment.rb - Packaging tasks

=end 

#configuration files
config_files = FileList.new("source/config/*.erb")

task :copy_config_files do
  config_files.each do |file|
      [configatron.artifacts_dir,configatron.app_dir].each do|folder|
        FileUtils.cp(file.name_without_template_extension,
        folder.join(file.base_name_without_extension))
      end
  end
end

%w[utils configuration tasks].each do|folder|
  Dir.glob(File.join(File.dirname(__FILE__),"build/#{folder}/*.rb")).each do|item|
    require item
  end
end

[configatron.artifacts_dir, configatron.specs.dir].each do |item|
  CLEAN.include(item)
end

Rake::Task['expand_all_template_files'].invoke


@project_files = FileList.new("#{configatron.source_dir}/**/*.csproj")


#target folders that can be run from VS
solution_file = "solution.sln"

task :default => ["specs:run"]

task :init  => :clean do
  [
    configatron.artifacts_dir,
    configatron.specs.dir,
    configatron.specs.report_dir,
  ].each do |folder| 
    FileUtils.mkdir_p folder if ! File.exists?(folder)
  end
end


namespace :build do
  desc 'compiles the project'
  task :compile => :init do
    opts = {
        :version => 'v4\Full',
        :switches => { :verbosity => :minimal, :target => :Build },
        :properties => {
          :Configuration => configatron.target,
          :TrackFileAccess => false,
          :PostBuildEvent => ""
        }
      }

      @project_files.each do |project|
        MSBuildRunner.build opts.merge({ :project => project }), 
        { 
            :OutputPath => configatron.artifacts_dir.to_absolute 
        }
      end
  end

  task :rebuild => ["clean","compile"]
end
