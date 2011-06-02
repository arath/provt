task :configure_db do
  configs = 
  {
    :db => 
    {
      :initial_catalog => delayed{configatron.project},
      :server_name => ENV['HOSTNAME'],
      :osql_connection_string => "-E",
      :web_account_sql => "#{configatron.db.web_user_account}, N'#{configatron.db.web_user_account}'",
      :app_connection => delayed{"data source=#{configatron.db.server_name};Integrated Security=SSPI;Initial Catalog=#{configatron.db.initial_catalog}"}
    }
  }

  configatron.configure_from_hash configs
end

Rake::Task[:configure_db].invoke
