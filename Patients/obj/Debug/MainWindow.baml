   M S B A M L   `   `   `  ����C  ?Patients, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PatientsPatients  5   	       Patients.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Patients     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��530��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ patientsGrid��5   /      AutoGenerateColumns .  $��	0,0,0,155q�6E      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First name��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	FirstName+6W     5      $ 	Last name��6B   $ 70 6U    6%   �� *
LastName+6U     5      $ 
Birth date��6C   $	 100 6W    6%   �� *	BirthDate+6W     5      $ Gender��6@   $ 50 6P    6%   �� *Gender+6P     5      $ Address��6A   $	 130 6R    6%   �� *	Address+6R     5      $ Phone��6?   $ 90 6N    6%   �� *Phone+6N   5      �� 5   
   -   5         ��Name$ firstNameTextBlock��5      $
��Left=�60   $��
10,230,0,0q�6K   $
��Wrap=�6_   $��First name:��6s   $	��Top=�6�   �� 5   
   -   5        	 ��Name$	 firstNameTextBox��5      $
��Left=�6,   $��20��6G   $��
67,230,0,0q�6S   
 �� TextWrapping$

 Wrap=�6g   $	��Top=�6{   $��93��6�   �� 5   
   -   5        $ lastNameTextBlock��5      $
��Left=�6/   $��
10,255,0,0q�6J   $
��Wrap=�6^   $��
Last name:��6r   $	��Top=�6�   �� 5   
   -   5        $	 lastNameTextBox��5      $
��Left=�6+   $��20��6F   $��
67,255,0,0q�6R   $

 Wrap=�6f   $	��Top=�6z   $��93��6�   �� 5   
   -   5        $ birthDateTextBlock��5      $
��Left=�60   $��
10,280,0,0q�6K   $
��Wrap=�6_   $��Birth date:��6s   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ birthDatePicker��5      $
��Left=�6.   $��
67,280,0,0q�6I   $	��Top=�6]   $��93��6u   �� 5   
   -   5        $ genderTextBlock��5      $
��Left=�6-   $��
10,305,0,0q�6H   $
��Wrap=�6\   $��Gender:��6p   $	��Top=�6   �� 5   
   -	   5         ��Name$ genderComboBox��5      $
��Left=�6+   $��
67,305,0,0q�6F   $	��Top=�6Z   $��93��6r   .@�5       �� $
��Male��6   �� 5!      $��Female��6   5"      �� 5#   
   -
   5        $ addressTextBlock��5#      $
��Left=�6.   $��182,230,0,0q�6I   $
��Wrap=�6^   $��Address:��6r   $	��Top=�6�   �� 5$   
   -   5        $	 addressTextBox��5$      $
��Left=�6*   $��20��6E   $��232,230,0,0q�6Q   $

 Wrap=�6f   $	��Top=�6z   $��93��6�   �� 5%   
   -   5        $ phoneTextBlock��5%      $
��Left=�6,   $��182,255,0,0q�6G   $
��Wrap=�6\   $��Phone:��6p   $	��Top=�6~   �� 5&   
   -   5        $	 phoneTextBox��5&      $
��Left=�6(   $��20��6C   $��232,255,0,0q�6O   $

 Wrap=�6d   $	��Top=�6x   $��93��6�   �� 5'   
   -   5         ��Name$ addNewPatientButton��5'      $	��Add��6.   $
��Left=�6<   $��232,305,0,0q�6W   $	��Top=�6l   $��75��6�   6�   �� 5(   
   -   5        $ errorTextBlock��5(      $
��Left=�6,   $��
67,343,0,0q�6G   $
��Wrap=�6[   $	��Top=�6o   $��20��6�   $	��412��6�   �� 5)   
   -   5        $ deleteButton��5)      $��Delete��6'   $
��Left=�68   $��346,230,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5*   
   -   5        $ 
editButton��5*      $
��Edit��6%   $
��Left=�64   $��437,230,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5+   
   -   5        $ visitsButton��5+      $��Visits��6'   $
��Left=�68   $��346,265,0,0q�6S   $	��Top=�6h   $��75��6�   6�   5,      5-      