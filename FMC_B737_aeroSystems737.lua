----------------------------------------------------------------------------
---- .lua script information -----------------------------------------------
----------------------------------------------------------------------------

	--[[
		Filename: 	FMC_B737_aeroSystems737.lua
		Author: 	Steven Dobler
		Date: 		7/4/2020
		email:		B737SimBuilders@gmail.com
	--]]

----------------------------------------------------------------------------
---- Purpose & use of .lua script ------------------------------------------
----------------------------------------------------------------------------

	--[[ 
		B737 aeroSystem737 Avionics Software:
		------------------------------------
			This script is intended for use with Aerosoft Austrilia's
			aeroSystem737 avionics suite.  It is low cost ($49 USD) 
			with a significant number of features and flexibility.
			There are two programs in their avionics suite.  They
			are AeroServer737 & AeroAvionics737 and can	be found at
			www.aerosoft.com.au. AeroServer737 runs on the PC where 
			FSX is installed, and AeroAvionics737 is run on all PCs
			where your avionics displays are run. See their	website
			for additional information on their product and how to
			configure multiple PCs in your simulator.
	--]]
	
	--[[ 
		FMC_B737_Aerosoft.lua
		---------------------
			This .lua script works with the EasyEDA FMC board design that
			was designed by me and can be found here:___________. This 
			circuit board design is built around a Teensy++2.0 processor
	--]]

	--[[ 
		FMC_B737_Teensy++2.0.ino
		------------------------
			The Arduino code that runs on the Teensy++ 2.0 was developed
			by me and can be found here:___________. 
	--]]

----------------------------------------------------------------------------
---- Preparing to use script with FSX Flight Simulator ---------------------
----------------------------------------------------------------------------

	--[[ 
		Step #1: 	Place a copy of this lua file FMC_B737_aeroSystems737.lua
					in the FSX "Modules" folder
					
		Step #2:	Open the "FSUIPC.ini file" found in the FSX "Modules" 
					folder using your preferred text editor (Example: NotePad)
					
		Step #3:	Add the following text to the FSUIPC.ini file exactly as
					shown:
		
						[Auto]
						1=luaFMC_B737_aeroSystems737
						
						[LuaFiles]
						1=FMC_B737_aeroSystems737
						
		Step #4:	Save the "FSUIPC.ini file"		

			Note:	By editing the FSUIPC.ini with the above text, it will 
					cause the FMC_B737_aeroSystems737.lua script to 
					automatically run when FSX starts up.
	--]]


----------------------------------------------------------------------------
---- Initial start up of this .lua script works ----------------------------
----------------------------------------------------------------------------

	--[[ 
		The first time you start FSX after copying this .lua script into
		the FSX Module folder and modified the FSUIPC.ini file as 
		described above, this .lua script uses the ipc.display("") command
		to display information on the FSX screen and to get information from
		you about the Comm port where the B737 FMC hardware (Teensy++ 2.0) 
		is plugged into on the FSX computer.  It will prompt you
		with the message "Could not open ARDUINO Com Port".  It will
		then prompt you with the message "Enter the Arduino Com Port
		for Your B737 FMC Hardware".
						
		Once you enter the port number and press enter a simple text 
		file named B737_FMC_Port_Number.txt will be created in the
		FSX "Modules" folder. The port number is stored in this file
		and on subsequent start ups of FSX, this .lua script it will 
		read the text in the file to get the port number and it will
		display "Arduino Com Port "..port_number.." Open" with 
		port_number being the number you entered during initial setup 
		described above.
			
		If you change the port where your B737 FMC hardware is connected,
		the PC may change it's port number.  If that happens, you would
		have to edit the B737_FMC_Port_Number.txt file using NotePad
		to change this port number.  Or, it will provide a message that 
		it can't open the Comm port and ask you again to enter it on the 
		FSX screen.
	--]]
	

----------------------------------------------------------------------------
---- Variables -------------------------------------------------------------
----------------------------------------------------------------------------
	
	port_file = "B737_FMC_Port_Number.txt" 
		-- File where Comm port is stored
	speed = 115200
		-- Baud Rate
	handshake = 0
	serial_wait = 1000

----------------------------------------------------------------------------
---- Comm Port set up and recording of Comm Port ---------------------------
----------------------------------------------------------------------------
	

	-- Try to open the file "B737_FMC_Port_Number.txt" in read mode
			file = io.open(port_file, "r") 
	
	-- If the file B737_FMC_Port_Number.txt doesn't exist
			if file == nil then 

			-- Set the port number to 10
					port_number = "10"
					
			-- Create a file named "B737_FMC_Port_Number.txt" in the FSX\Modules folder
					file = io.open(port_file, "w") 

			-- Set the file "B737_FMC_Port_Number.txt" as default output file	
					io.output(file)

			-- Write the number 10 to the "B737_FMC_Port_Number.txt" file
					io.write(port_number)
			
			-- Close the "B737_FMC_Port_Number.txt" file
					io.close(file)
             
			-- Set the Comm Port com.open(port number, baud rate, No Handshake)
					B737_FMC_Com_Port = com.open("COM"..port_number, speed, handshake)

		else
			-- After the "B737_FMC_Port_Number.txt" file was created & the port written
			-- Get the port number from the file (Read up to 2 characters)
					port_number = file:read (2)

			-- Close the "B737_FMC_Port_Number.txt" file
					io.close(file)

			-- Set the Comm Port number to the number saved in the "B737_FMC_Port_Number.txt" file
					B737_FMC_Com_Port = com.open("COM"..port_number, speed, handshake)
	end 

	-- If the "B737_FMC_Com_Port" does not equal (~=) zero
		if B737_FMC_Com_Port ~= 0 then

		-- Display a message that tells you it was able to open the comm port successfully
			ipc.display("B737_FMC Com Port "..port_number.." Open",5)
                
		else
            ipc.display("Could not open ARDUINO Com Port")
            ipc.sleep(2000)
            port_number = ipc.ask('\n'..'\n'..'\n'..'\n'..'\n'..'\n'..'\n'..'\n'.." Enter the Arduino Com Port for Your B737 FMC Hardware")
            file = io.open(port_file, "w")
            io.output(file)
            io.write(port_number)
            io.close(file)

            B737_FMC_Com_Port = com.open("COM"..port_number, speed, handshake)
                
    if B737_FMC_Com_Port == 0 
	
		then
            ipc.display("Could not open ARDUINO Com Port",5)                         
            ipc.exit()
        
		else
        ipc.display("Arduino Com Port "..port_number.." Open",5)
                                
     end
end 

----------------------------------------------------------------------------
---- Functions -------------------------------------------------------------
----------------------------------------------------------------------------

	--[[ 
		Below are the functions used in this script.  When data comes in 
		from the from the B737 FMC hardware it gets sent to this 
		function.  When it finds one of the strings in "" it does that
		ipc.control.
	--]]

----------------------------------------------------------------------------
---- Arduino_Data() Function -----------------------------------------------
----------------------------------------------------------------------------

function Arduino_Data(B737_FMC_Com_Port, datastring, length)
                 
	ipc.writeSW(0x07371, datastring)
	ipc.writeSB(0x07370, 0xFA)
                
end  -- function end

--This script is to read the AeroSoft CDU MGS LED and display it on the screen


----------------------------------------------------------------------------
---- CDU_MSG_LED() Function ------------------------------------------------
----------------------------------------------------------------------------

	--[[ 
		The MSG LED on the AeroAvionics737 software is located at FSUIPC
		hex address 0x7378.  If this value is hex 0x0004 it means that
		the LED is ON.  If the value is hex 0x0000 it means that the LED
		if OFF.
		
		If the value is ON, it write a less than "<" symbol, an "M" and "\r" 
		which is a return or enter character to the B737FMC Arduino program
	--]]

function CDU_MSG_LED(offset, value)
			serial_wait = 1000
			MSG_LED = ipc.readUW(0x7378) -- Read the value at 0x0000

		if MSG_LED == 0x0004 -- Value indicating the LED is ON
			then
                com.write(B737_FMC_Com_Port, "<M\r") 
                serial_wait = 1000
			end 

-- if the HEX value from Aerosoft is 0x0000 it inidates the LED is OFF


if MSG_LED == 0x0000 then
                com.write(B737_FMC_Com_Port, "<O\r")  -- Currently this test turns the Arduino EXEC LED OFF
               serial_wait = 1000
end -- End of if MSG_LED OFF


end -- End of CDU_MSG_LED function



---- End of Functions section -----------------------


----------------------------------------------------------------------------
---- Events ----------------------------------------------------------------
----------------------------------------------------------------------------
-- Events are awesome. They don't require a continuous loop to work.
-- They just sit back and wait for a trigger and then spring into action.
-- Events must go at the bottom of the script. Why? Google it.

event.com(B737_FMC_Com_Port, 5,1, "Arduino_Data")
                -- This is event.com, it listens for data on the Arduinos Com port.
                -- The 5 and 1 are the max and min characters accepted
                -- The data is then passed to the "Arduino_Data" function above.


event.offset(0x7378, "UW", "CDU_MSG_LED")  

---- End of Events section --------------------------

