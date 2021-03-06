﻿using System;
using System.Text;

namespace GensouSakuya.Aria2.Desktop.Core
{
    public class Aria2Config
    {
        //是否已存在可用的Aria2服务
        public bool IsAria2ServerExist { get; set; } = false;

        //启用rpc:enable-rpc=true 必须配置
        //允许外部访问:rpc-listen-all=true 必须配置

        public string Aria2Path { get; set; } = $@".\Aria2\{(Environment.Is64BitOperatingSystem ? "x64" : "x86")}\aria2c-fg.exe";
        
        //Aria2服务地址
        public string Aria2Host { get; set; } = "localhost";

        //RPC端口，默认6800
        //rpc-listen-port
        public int ListenPort { get; set; } = 6800;

        //最大同时下载数(任务数), 路由建议值: 3
        //max-concurrent-downloads=3
        public int MaxCurrentDownloads { get; set; } = 3;

        //是否启用断点续传
        //continue=true
        public bool EnableRedownload { get; set; } = true;

        //同服务器连接数
        //max-connection-per-server=16
        public int ConnectionPerServer { get; set; } = 16;

        //最小文件分片大小, 下载线程数上限取决于能分出多少片, 对于小文件重要
        //min-split-size=10M
        public int MinSplitSize { get; set; } = 10;

        //单文件最大线程数, 路由建议值: 5
        //测试后看看是否需要
        //split=256
        
        //下载速度限制
        //max-overall-download-limit=0
        public int DownloadSpeedLimit { get; set; } = 0;

        //单文件下载速度限制
        //测试后看看是否需要
        //max-download-limit=0
        
        //上传速度限制
        //max-overall-upload-limit=0
        public int UploadSpeedLimit { get; set; } = 0;

        //单文件上传速度限制
        //测试后看看是否需要
        //max-upload-limit=0

        //文件保存路径, 默认为当前启动位置下Downloads文件夹
        //dir="./"
        public string DownloadPath { get; set; } = "./Downloads";

        //是否允许跨域访问
        public bool AllowOriginAll { get; set; } = false;

        //使用代理
        //测试后看看是否需要
        //all-proxy=localhost:1080

        public string ToArgs()
        {
            var configStr = new StringBuilder();
            configStr.Append($"--enable-rpc=true --rpc-listen-all=true --rpc-listen-port={ListenPort} --rpc-allow-origin-all={AllowOriginAll.ToString().ToLower()} ");
            configStr.Append(
                $"--max-concurrent-downloads={MaxCurrentDownloads} --continue={EnableRedownload.ToString().ToLower()} --max-connection-per-server={ConnectionPerServer} ");
            configStr.Append(
                $"--min-split-size={MinSplitSize}M --max-overall-download-limit={DownloadSpeedLimit} --max-overall-upload-limit={UploadSpeedLimit} ");
            configStr.Append($@"--dir=""{DownloadPath}"" ");
            return configStr.ToString();
        }
    }
}
