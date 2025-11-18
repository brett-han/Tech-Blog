#### automatic install nginx cert (https)
* sudo certbot install --cert-name www.xxx.com

#### git-filter-repo: Rewrite Your Git History Like a Time Traveler
* Replace old email with new email throughout all history
```echo "old@gmail.com==>new@gmail.com" > replacements.txt
git-filter-repo --replace-text replacements.txt --force
git push --force
```
#### grep white line in config file
* grep -Ev '^$|;' /etc/php/8.4/fpm/php-fpm.conf