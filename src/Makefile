.PHONY: all pack clean run

path = Calculator_material/bin/Debug/
exe = Calculator_material.exe
dir = xdvora3k_xkvasn14_xkuzel08


all: run

pack:
	cd ../.. && powershell.exe Compress-Archive -path $(dir) -DestinationPath $(dir)

clean:
	powershell.exe Remove-Item -recurse -path .vs -erroraction Ignore; powershell.exe Remove-Item -path Calculator_material/bin/* -Exclude "*.exe","*.dll" -recurse -erroraction Ignore;
	powershell.exe Remove-Item -recurse -path Mathematics/.vs -erroraction Ignore; powershell.exe Remove-Item -path Mathematics/bin/* -recurse -erroraction Ignore;
	powershell.exe Remove-Item -recurse -path MathLibTests/.vs -erroraction Ignore; powershell.exe Remove-Item -path MathLibTests/bin/* -recurse -erroraction Ignore;
	powershell.exe Remove-Item -recurse -path Profiling/.vs -erroraction Ignore; powershell.exe Remove-Item -path Profiling/bin/* -recurse -erroraction Ignore

run:
	$(path)$(exe)