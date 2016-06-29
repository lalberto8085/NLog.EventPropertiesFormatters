#NLog Event Properties Formaters

###Have you ever needed/wanted to log `${all-event-properties}` as a json without hacking your way into it?

Well, `NLog.EventPropertiesFormaters` does just that, provides some custom `LayoutRenderer`s to save the `${all-event-properties}` 
in various formats, firstly `json` and `xml`. 