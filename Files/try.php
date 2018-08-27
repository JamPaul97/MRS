<?php
if(fsockopen(htmlspecialchars($_GET["ip"]),htmlspecialchars($_GET["port"])))
{
echo  "true";
}
else
{
echo  "false";
}
?>
