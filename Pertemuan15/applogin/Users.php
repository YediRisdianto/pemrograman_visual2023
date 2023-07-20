<?php
//Simpanlah dengan nama file : Users.php
require_once 'database.php';
class Users 
{
    private $db;
    private $table = 'users';
    public $username = "";
    public $passwd = "";
    public $rolename = "";
    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }
    
    public function login($username,$passwd){
        $passwd = MD5($passwd);
        $query = "SELECT * FROM $this->table WHERE username = '{$username}' and passwd='{$passwd}'";
        $hasil = $this->db->query($query);   
        $data =  $this->db->fetch($hasil);
                
        if($this->db->affected_rows()>0){
            return $data['rolename'];
        } else {
            return null;
        } 
    }
    
}
?>