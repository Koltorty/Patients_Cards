   M S B A M L   `   `   `  ����C  ?Patients, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PatientsPatients  5   	        Patients.PatientEditWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Patients     5   	     � Title$  PatientEditWindow��5   	   $��356.391��6#   $��204.248��64   .��5	      � .+�5
   
   �� -   5         ��Name$ firstNameTextBox��5
      $
��Left=�6,   $��20��6G   $��	72,26,0,0q�6S    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��100��6�   �� 5   
   -   5         ��Name$ firstNameTextBlock��5      $
��Left=�60   $��	10,26,0,0q�6K   $
��Wrap=�6^   $��First name:��6r   $	��Top=�6�   �� 5   
   -   5        $ lastNameTextBlock��5      $
��Left=�6/   $��	10,60,0,0q�6J   $
��Wrap=�6]   $��
Last name:��6q   $	��Top=�6�   �� 5   
   -   5        $ lastNameTextBox��5      $
��Left=�6+   $��20��6F   $��	71,60,0,0q�6R   $
 Wrap=�6e   $	��Top=�6y   $	��101��6�   �� 5   
   -   5        $ birthDateTextBlock��5      $
��Left=�60   $��	10,97,0,0q�6K   $
��Wrap=�6^   $��Birth date:��6r   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ birthDatePicker��5      $
��Left=�6.   $��	72,97,0,0q�6I   $	��Top=�6\   $��25��6t   �� 5   
   -   5        $ genderTextBlock��5      $
��Left=�6-   $��
10,132,0,0q�6H   $
��Wrap=�6\   $��Gender:��6p   $	��Top=�6   �� 5   
   -   5         ��Name$ genderComboBox��5      $
��Left=�6+   $��
71,132,0,0q�6F   $	��Top=�6Z   $	��101��6r   .@�5      �� $
��Male��6   �� 5      $��Female��6   5      �� 5   
   -	   5        $ addressTextBlock��5      $
��Left=�6.   $��
10,166,0,0q�6I   $
��Wrap=�6]   $��Address:��6q   $	��Top=�6�   �� 5   
   -
   5        $ addressTextBox��5      $
��Left=�6*   $��20��6E   $��
71,168,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��101��6�   �� 5   
   -   5        $ phoneTextBlock��5      $
��Left=�6,   $��
10,202,0,0q�6G   $
��Wrap=�6[   $��Phone:��6o   $	��Top=�6}   �� 5   
   -   5        $ phoneTextBox��5      $
��Left=�6(   $��20��6C   $��
71,204,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��101��6�   �� 5   
   -   5        $ errorTextBlock��5      $
��Left=�6,   $��
17,278,0,0q�6G   $
��Wrap=�6[   $	��Top=�6o   $	��155��6�   $��37��6�   �� 5   
   -   5         ��Name$ 
saveButton��5      $
��Save��6%   $
��Left=�64   $��
57,242,0,0q�6O   $	��Top=�6c   $��75��6{   6�   5      5      