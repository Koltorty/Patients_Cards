   M S B A M L   `   `   `  ����C  ?Patients, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PatientsPatients  5   	       Patients.VisitsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Patients     5   	     � Title$  VisitsWindow��5   	   $��323.684��6   $	��262��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
visitsGrid��5   /      AutoGenerateColumns .  $��	0,0,0,171q�6C      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Visit date��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	VisitDate+6W     5      $ 	Diagnosis��6C   $	 100 6V    6%   �� *	Diagnosis+6V     5      $ 
Visit type��6C   $ 70 6W    6%   �� *	VisitType+6W   5      �� 5   
   -   5         ��Name$ visitDateTextBlock��5      $
��Left=�60   $��
10,128,0,0q�6K   $
��Wrap=�6_   $��Date:��6s   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 visitDatePicker��5      $
��Left=�6.   $��
69,127,0,0q�6I   $	��Top=�6]   $��90��6u   �� 5   
   -   5        $ diagnosisTextBlock��5      $
��Left=�60   $��
10,156,0,0q�6K   $
��Wrap=�6_   $��
Diagnosis:��6s   $	��Top=�6�   �� 5   
   -   5        
 ��Name$
 diagnosisTextBox��5      $
��Left=�6,   $��20��6G   $��
69,156,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $��90��6�   �� 5   
   -   5        $ visitTypeTextBlock��5      $
��Left=�60   $��
10,187,0,0q�6K   $
��Wrap=�6_   $��Visit type:��6s   $	��Top=�6�   �� 5   
   -   5         ��Name$ visitTypeComboBox��5      $
��Left=�6.   $��
69,187,0,0q�6I   $	��Top=�6]   $��90��6u   .@�5      �� $��First��6   �� 5      $��Second��6   5      �� 5   
   -   5         ��Name$ 	addButton��5      $	��Add��6$   $
��Left=�62   $��
10,224,0,0q�6M   $	��Top=�6a   $��75��6y   6�   �� 5   
   -	   5        $ errorTextBlock��5      $
��Left=�6,   $��
10,249,0,4q�6G   $
��Wrap=�6[   $	��234��6o   �� 5    
   -
   5        $ deleteButton��5       $��Delete��6'   $
��Left=�68   $��
90,224,0,0q�6S   $	��Top=�6g   $��75��6   6�   �� 5!   
   -   5        $ 
editButton��5!      $
��Edit��6%   $
��Left=�64   $��170,224,0,0q�6O   $	��Top=�6d   $��75��6|   6�   5"      5#      