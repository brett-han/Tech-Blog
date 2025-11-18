#### automatic install nginx cert (https)

``` bash
    sudo certbot --nginx -d www.xxx.com
```
#### git-filter-repo: Rewrite Your Git History Like a Time Traveler
* Replace old email with new email throughout all history
```bash
        echo "old@gmail.com==>new@gmail.com" > replacements.txt

        git-filter-repo --replace-text replacements.txt --force
        
        git push --force
```
#### grep white line in config file
```bash
    grep -Ev '^$|;' /etc/php/8.4/fpm/php-fpm.conf
```