# SuperNAT
SuperNAT是基于net core 3.0正式版的内网穿透程序，类似花生壳，目前仅支持http穿透，tcp穿透会在后续加入，SuperNAT.Server为服务端，SuperNAT.Client为客户端。<br/>
管理后台：http://www.supernat.cn:8088
![Image text](https://github.com/yangan666/SuperNAT/blob/master/Img/manage.png)
<br/>
<br/>
window服务器的部署：
第一步：先下载net core 3.0运行时，地址：https://dotnet.microsoft.com/download/dotnet-core/3.0 选择下载Runtime 3.0.0 ASP.NET Core/.NET Core: Runtime & Hosting Bundle，安装到服务器。<br/>
第二步：下载源码生成SuperNAT.Server，修改配置文件appsettings.json的配置<br/>
![Image text](https://github.com/yangan666/SuperNAT/blob/master/Img/server.config.png)
第三步：安装mariadb或mysql，数据库脚本位置：SuperNAT.Server/DB，创建数据库supernat，先执行脚本create.sql，然后执行data.sql，修改SuperNAT.Server配置文件appsettings.json的DBConfig>ConnetionString为你的数据库连接字符串。<br/>
第四步：启动SuperNAT.Server控制台程序，浏览器打开http://你的域名:8088，默认管理员：admin，密码：123456<br/>
第五步：内网穿透>主机管理>新建主机，生成主机密钥，然后在端口映射创建你的应用。<br/>

window客户端的部署：
下载源码生成SuperNAT.Client，修改配置文件appsettings.json的配置<br/>
![Image text](https://github.com/yangan666/SuperNAT/blob/master/Img/client.config.png)<br/>
