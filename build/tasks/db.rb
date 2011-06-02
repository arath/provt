class SqlRunner
  class << self
    def process_sql_files(files)
      runner = "osql"
      trigger = "#{runner} #{configatron.db.osql_connection_string}"

      puts trigger
      files.each do|sql_file|
        item = "#{trigger} #{configatron.db.osql_args_prior_to_file_name} #{sql_file}"
        puts item
        sh "#{item}"
      end
    end
  end
end

def create_sql_fileset(path)
  Dir.glob(File.join(configatron.db.scripts_path,path,"**/*.sql"))
end


namespace :db do
  desc 'tears down the database and recreates it from the ddl files'
  task :create_schema => [:init] do
      SqlRunner.process_sql_files(create_sql_fileset('ddl'))
  end

  desc 'loads the database with acceptance testing data'
  task :load_data => :create_schema do
      SqlRunner.process_sql_files(create_sql_fileset('data'))
  end
end

