Public Class Server_Properties_Class

    Public Class properties_object
        Public Enum _difficulty
            Peaceful = 0
            Easy = 1
            Normal = 2
            Hard = 3
        End Enum
        Public Enum _gamemode
            Survival = 0
            Createive = 1
            Adventure = 2
            Spectator = 3
        End Enum
        Public allow_flight As Boolean = False
        Public allow_nether As Boolean = True
        Public difficulty As _difficulty = _difficulty.Easy
        Public enable_query As Boolean = False
        Public enable_rcon As Boolean = False
        Public enable_command_block As Boolean = False
        Public force_gamemode As Boolean = False
        Public gamemode As _gamemode = _gamemode.Survival
        Public generate_structures As Boolean = True
        Public generator_settings As String
        Public hardcore As Boolean = False
        Public level_name As String = "world"
        Public level_type As String
        Public max_build_height As Integer = 256
        Public max_players As Integer = 20
        Public max_tick_time As Integer = 60000
        Public max_world_size As Integer = 29999984
        Public motd As String = "A Minecraft Server"
        Public network_compression_threshold As Integer = 256
        Public online_mode As Boolean = True
        Public op_permission_level As Integer = 4
        Public player_idle_timeout As Integer = 0
        Public prevent_proxy_connections As Boolean = False
        Public pvp As Boolean = True
        Public query_port As Integer = 25565
        Public rcon_password As String
        Public resource_pack As String
        Public resource_pack_sha1 As String
        Public server_ip As String
        Public server_port As Integer = 25565
        Public snooper_enabled As Boolean = True
        Public spawn_animals As Boolean = True
        Public spawn_monsters As Boolean = True
        Public spawn_npcs As Boolean = True
        Public spawn_protection As Integer = 16
        Public ReadOnly use_native_transport As Boolean = False
        Public view_distance As Integer = 10
        Public white_list As Boolean = False
        Public enforce_whitelist As Boolean = False
    End Class
    Public Function getPropertiesFile(ByVal pObject As properties_object)
        Dim str As String
        str = "allow-flight=" & pObject.allow_flight & vbNewLine _
        & "allow-nether=" & pObject.allow_nether & vbNewLine _
        & "difficulty=" & pObject.difficulty & vbNewLine _
        & "enable-command-block=" & pObject.enable_command_block & vbNewLine _
        & "enable-query=" & pObject.enable_query & vbNewLine _
        & "enable-rcon=" & pObject.enable_rcon & vbNewLine _
        & "enforce-whitelist=" & pObject.enforce_whitelist & vbNewLine _
        & "force-gamemode=" & pObject.force_gamemode & vbNewLine _
        & "gamemode=" & pObject.gamemode & vbNewLine _
        & "generate-structures=" & pObject.generate_structures & vbNewLine _
        & "generator-settings=" & pObject.generator_settings & vbNewLine _
        & "harcore=" & pObject.hardcore & vbNewLine _
        & "level-name=" & pObject.level_name & vbNewLine _
        & "level-type=" & pObject.level_type & vbNewLine _
        & "max-build-height=" & pObject.max_build_height & vbNewLine _
        & "max-players=" & pObject.max_players & vbNewLine _
        & "max-tick-time=" & pObject.max_tick_time & vbNewLine _
        & "max-world-size=" & pObject.max_world_size & vbNewLine _
        & "motd=" & pObject.motd & vbNewLine _
        & "network-compression-threshold=" & pObject.network_compression_threshold & vbNewLine _
        & "online-mode=" & pObject.online_mode & vbNewLine _
        & "op-permission-level=" & pObject.op_permission_level & vbNewLine _
        & "player-idle-timeout=" & pObject.player_idle_timeout & vbNewLine _
        & "prevent-proxy-connections=" & pObject.prevent_proxy_connections & vbNewLine _
        & "pvp=" & pObject.pvp & vbNewLine _
        & "query.port=" & pObject.query_port & vbNewLine _
        & "rcon.password=" & pObject.rcon_password & vbNewLine _
        & "resource-pack=" & pObject.resource_pack & vbNewLine _
        & "resource-pack-sha1=" & pObject.resource_pack_sha1 & vbNewLine _
        & "server-ip=" & pObject.server_ip & vbNewLine _
        & "server.port=" & pObject.server_port & vbNewLine _
        & "snooper-enabled=" & pObject.snooper_enabled & vbNewLine _
        & "spawn-animals=" & pObject.spawn_animals & vbNewLine _
        & "spawn-monsters=" & pObject.spawn_monsters & vbNewLine _
        & "spawn-npcs=" & pObject.spawn_npcs & vbNewLine _
        & "spawn-protection=" & pObject.spawn_protection & vbNewLine _
        & "use-native-transport=" & pObject.use_native_transport & vbNewLine _
        & "view-distance=" & pObject.view_distance & vbNewLine _
        & "white-list=" & pObject.white_list & vbNewLine
        Return (str)
    End Function
    Public Function getDefaultProperties()
        Dim temp As New properties_object
        Dim str = getPropertiesFile(temp)
        Return (str)
    End Function
End Class
