   M S B A M L   `   `   `  ����C  ?Patients, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Patients.WindowsPatients.Windows  5   	   &     Patients.Windows.VisitEditWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Patients.Windows     5   	     � Title$  VisitEditWindow��5   	   $��290.977��6!   $	��204��62   .��5	      � .+�5
   
   �� -   5         ��Name$ dateTextBlock��5
      $
��Left=�6+   $��	10,30,0,0q�6F   $
��Wrap=�6Y   $��Date:��6m   $	��Top=�6z   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ visitDatePicker��5      $
��Left=�6.   $��	69,30,0,0q�6I   $	��Top=�6\   $��90��6t   �� 5   
   -   5        $ diagnosisTextBlock��5      $
��Left=�60   $��	10,71,0,0q�6K   $
��Wrap=�6^   $��
Diagnosis:��6r   $	��Top=�6�   �� 5   
   -   5         ��Name$ diagnosisTextBox��5      $
��Left=�6,   $��20��6G   $��	69,71,0,0q�6S    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $��90��6�   �� 5   
   -   5        $ visitTypeTextBlock��5      $
��Left=�60   $��
14,114,0,0q�6K   $
��Wrap=�6_   $��Visit type:��6s   $	��Top=�6�   �� 5   
   -   5         ��Name$ visitTypeComboBox��5      $
��Left=�6.   $��
69,114,0,0q�6I   $	��Top=�6]   $��90��6u   .@�5      �� $��First��6   �� 5      $��Second��6   5      �� 5   
   -   5         ��Name$ 
saveButton��5      $
��Save��6%   $
��Left=�64   $��
60,166,0,0q�6O   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5        $ errorTextBlock��5      $
��Left=�6,   $��
16,205,0,0q�6G   $
��Wrap=�6[   $	��Top=�6o   $	��170��6�   $��42��6�   5      5      