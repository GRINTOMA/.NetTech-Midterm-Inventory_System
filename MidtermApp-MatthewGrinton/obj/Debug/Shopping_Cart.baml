   M S B A M L   `   `   `  ����T  PMidtermApp-MatthewGrinton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:MidtermApp_MatthewGrintonMidtermApp_MatthewGrinton  5   	   '    !MidtermApp_MatthewGrinton.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:MidtermApp_MatthewGrinton     5   	   -   5          �Name$  ShoppingCartWindow��5   	    � Title$* $Shopping Cart Summary-MatthewGrinton��5   	   $��320.4��66   $��528.56��6E   .��5	      � $	��225��6   $	��Top=�6   .+�5
   
   �� -   5         ��Name$ 
Cart_Label��5
      $��Shopping Cart:��6$   $
��Left=�6=   $��	17,24,0,0q�6X   $	��Top=�6k   �� 5   
   -   5         ��Name$
 Cart��5      $
��Left=�5      $	��126��5      $��	12,55,0,0q�5      $	��Top=�5      $	��452��5      $��0��5      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5      $��RightToLeft=�5      ��5      �� *
Products+ �� SelectedItem 5      �� *SelectedItem+ �� View 5      �� 5      P�5      �� 5      $��On Sale��6)    �� Width$	 100��5   -    �� DisplayMemberBinding 5   -   �� 	 �� Path$
	 sale��� 5      $��Product Quantity��6)   $	 100��5   -    5   -   �� $	 quantity��� 5      $��Product Price��6)   $ 95��5    -    5!   -   �� $	 price��� 5"      $��Product Name��6)   $	 150��5#   -    5$   -   �� $
	 name�5&      5(      �� 5)   
   -   5        $ 
Cost_Label��5)      $��Product Cost:��6$   $
��Left=�6<   $��43,244,0,-45q�6W   $	��Top=�6m   �� 5*   
   
���   �$��1q�6%   $
��Left=�69   $��26��6T   $��136,244,0,-45q�6`   $	��Top=�6w   $��77��6�   ._�5+      �� -   5        
 ��Name$

 Cost��5+       �� TextWrapping$
 Wrap=�6$   $�� ��68    �� 
IsReadOnly . 6@   5,      �� 5-   
   -   5        $ Order_Total_Label��5-      $��Order Total:��6+   $
��Left=�6B   $��235,244,0,-45q�6]   $	��Top=�6t   �� 5.   
   
���   �$��1q�6%   $
��Left=�69   $��24��6T   $��312,244,0,-43q�6`   $	��Top=�6w   $��73��6�   ._�5/      �� -   5        $
 Total��5/      $
 Wrap=�6%   $�� ��69    . 6A   50      �� 51   
   -   5         ��Name$ Close��51      $��Close��6    $
��Left=�60   $��27��6K   $��418,239,0,-41q�6W   $	��Top=�6n   $��76��6�   6�   53      54      